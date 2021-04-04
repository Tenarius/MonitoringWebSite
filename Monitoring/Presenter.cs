using System;
using System.Windows.Forms;

namespace Monitoring
{
    class Presenter
    {
        private Model model;
        private View view;
        int focusRow;

        public Presenter(View view)
        {
            model = new Model();
            this.view = view;

            #region Events
            view.InitTable += InitTable;
            view.AddData += AddDataTable;
            view.SelectRow += GetSelectedData;
            view.Change += ChangeData;
            view.Delete += DeleteWebSite;
            view.UpdateData += UpdateStatusWebSite;
            #endregion
        }

        // Отрабатываем событие нажатие кнопки "Обновить".
        private void UpdateStatusWebSite(object sender, EventArgs e)
        {
            view.tableWebSites.Rows.Clear();
            UpdateData();
        }

        // Отрабатываем событие нажатие кнопки "Удалить".
        private void DeleteWebSite(object sender, EventArgs e)
        {
            if (model.Delete(focusRow))
            {
                view.tableWebSites.Rows.Clear();
                UpdateData();
            }
        }

        // Отрабатываем событие нажатие кнопки "Изменить".
        private void ChangeData(object sender, EventArgs e)
        {
            if (model.Edit(focusRow, GetWebSite()))
            {
                view.tableWebSites.Rows.Clear();
                UpdateData();
            }         
        }

        // Получаем строку с таблицы и отображаем в TexBox.
        private void GetSelectedData(object sender, EventArgs e)
        {        
            if (sender is int index)
            {
                focusRow = index;
               
                // TODO: Подумать как сократить.
                view.textNameWebSite.Text = model.webSites[index].name;
                view.textUrlWebSite.Text = model.webSites[index].url;
                view.textTimerWebSite.Text = model.webSites[index].timer.ToString();
            }
        }

        // Отрабатываем событие нажатие кнопки "Добавить".
        private void AddDataTable(object sender, EventArgs e)
        {
            if (model.FindWebSite(GetWebSite()))
            {
                MessageBox.Show("Веденные данные уже есть в таблице!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (model.Add(GetWebSite()))
            {
                AddRow(GetWebSite());
            }
        }

        // При запуске формы инициализируем таблицу.
        private void InitTable(object sender, EventArgs e)
        {
            UpdateData();
        }

        // Заполняем табоицу.
        private void UpdateData()
        {
            foreach (var web in model.webSites)
            {
                AddRow(web);
            }           
        }

        // Добавляем строку в таблицу.
        private void AddRow(WebSite webSite)
        {
            if (webSite != null)
            {
                view.tableWebSites.Rows.Add(webSite.name, webSite.url, webSite.timer, webSite.status);
            }
        }

        // Получам данные с TextBox.
        private WebSite GetWebSite()
        {
            if (view.textNameWebSite.Text == "" && view.textUrlWebSite.Text == "" && view.textTimerWebSite.Text == "")
            {
                return null;
            }

            return new WebSite(view.textNameWebSite.Text, view.textUrlWebSite.Text, Convert.ToInt32(view.textTimerWebSite.Text));
        }
    }
}
