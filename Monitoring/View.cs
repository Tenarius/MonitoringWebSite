using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Monitoring
{
    public partial class View : Form
    {
        #region Events
        public event EventHandler InitTable;
        public event EventHandler AddData;
        public event EventHandler SelectRow;
        public event EventHandler Change;
        public event EventHandler Delete;
        public event EventHandler UpdateData;
        #endregion

        public View()
        {
            InitializeComponent();
        }

        private void ViewLoad(object sender, EventArgs e)
        {
            InitTable?.Invoke(sender, e);
        }

        private void AddDataClick(object sender, EventArgs e)
        {
            AddData?.Invoke(sender, e);
        }

        private void SelectedRow(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex is int index)
            {
                SelectRow?.Invoke(index, e);
            }
        }

        private void ChangeClick(object sender, EventArgs e)
        {
            Change?.Invoke(sender, e);
        }

        private void DeleteWebSiteClick(object sender, EventArgs e)
        {
            Delete?.Invoke(sender, e);
        }

        private void UpdateClick(object sender, EventArgs e)
        {
            UpdateData?.Invoke(sender, e);
        }

        private void TimerValidating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(textTimerWebSite.Text, out int time))
            {
                if (time < 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(textTimerWebSite, "Таймер не может быть отрицательным.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(textTimerWebSite, "");
                }
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(textTimerWebSite, "Тамер не может состоять из буквенных значений");
            }
        }
    }
}