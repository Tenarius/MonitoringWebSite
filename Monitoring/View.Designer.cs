
namespace Monitoring
{
    partial class View
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutInput = new System.Windows.Forms.FlowLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.textNameWebSite = new System.Windows.Forms.TextBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.textUrlWebSite = new System.Windows.Forms.TextBox();
            this.labelTimer = new System.Windows.Forms.Label();
            this.textTimerWebSite = new System.Windows.Forms.TextBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.layoutTable = new System.Windows.Forms.FlowLayoutPanel();
            this.tableWebSites = new System.Windows.Forms.DataGridView();
            this.nameWebSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.layoutInput.SuspendLayout();
            this.layoutTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableWebSites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutInput
            // 
            this.layoutInput.Controls.Add(this.labelName);
            this.layoutInput.Controls.Add(this.textNameWebSite);
            this.layoutInput.Controls.Add(this.labelUrl);
            this.layoutInput.Controls.Add(this.textUrlWebSite);
            this.layoutInput.Controls.Add(this.labelTimer);
            this.layoutInput.Controls.Add(this.textTimerWebSite);
            this.layoutInput.Controls.Add(this.buttonAccept);
            this.layoutInput.Controls.Add(this.buttonChange);
            this.layoutInput.Controls.Add(this.buttonDelete);
            this.layoutInput.Controls.Add(this.buttonUpdate);
            this.layoutInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutInput.Location = new System.Drawing.Point(0, 0);
            this.layoutInput.Name = "layoutInput";
            this.layoutInput.Size = new System.Drawing.Size(800, 72);
            this.layoutInput.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(123, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Наименование сайта";
            // 
            // textNameWebSite
            // 
            this.textNameWebSite.Location = new System.Drawing.Point(132, 3);
            this.textNameWebSite.Name = "textNameWebSite";
            this.textNameWebSite.Size = new System.Drawing.Size(100, 23);
            this.textNameWebSite.TabIndex = 6;
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(238, 0);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(28, 15);
            this.labelUrl.TabIndex = 2;
            this.labelUrl.Text = "URL";
            // 
            // textUrlWebSite
            // 
            this.textUrlWebSite.Location = new System.Drawing.Point(272, 3);
            this.textUrlWebSite.Name = "textUrlWebSite";
            this.textUrlWebSite.Size = new System.Drawing.Size(100, 23);
            this.textUrlWebSite.TabIndex = 7;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(378, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(48, 15);
            this.labelTimer.TabIndex = 4;
            this.labelTimer.Text = "Таймер";
            // 
            // textTimerWebSite
            // 
            this.textTimerWebSite.Location = new System.Drawing.Point(432, 3);
            this.textTimerWebSite.Name = "textTimerWebSite";
            this.textTimerWebSite.Size = new System.Drawing.Size(100, 23);
            this.textTimerWebSite.TabIndex = 8;
            this.textTimerWebSite.Validating += new System.ComponentModel.CancelEventHandler(this.TimerValidating);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(538, 3);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(94, 30);
            this.buttonAccept.TabIndex = 9;
            this.buttonAccept.Text = "Принять";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.AddDataClick);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(638, 3);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(94, 30);
            this.buttonChange.TabIndex = 11;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.ChangeClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(3, 39);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 30);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.DeleteWebSiteClick);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(103, 39);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(129, 30);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Обновить статус";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.UpdateClick);
            // 
            // layoutTable
            // 
            this.layoutTable.Controls.Add(this.tableWebSites);
            this.layoutTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layoutTable.Location = new System.Drawing.Point(0, 103);
            this.layoutTable.Name = "layoutTable";
            this.layoutTable.Size = new System.Drawing.Size(800, 347);
            this.layoutTable.TabIndex = 1;
            // 
            // tableWebSites
            // 
            this.tableWebSites.AllowUserToAddRows = false;
            this.tableWebSites.AllowUserToDeleteRows = false;
            this.tableWebSites.AllowUserToResizeColumns = false;
            this.tableWebSites.AllowUserToResizeRows = false;
            this.tableWebSites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableWebSites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameWebSite,
            this.url,
            this.timer,
            this.colStatus});
            this.tableWebSites.Location = new System.Drawing.Point(3, 3);
            this.tableWebSites.MultiSelect = false;
            this.tableWebSites.Name = "tableWebSites";
            this.tableWebSites.ReadOnly = true;
            this.tableWebSites.RowTemplate.Height = 25;
            this.tableWebSites.ShowCellErrors = false;
            this.tableWebSites.ShowCellToolTips = false;
            this.tableWebSites.ShowEditingIcon = false;
            this.tableWebSites.ShowRowErrors = false;
            this.tableWebSites.Size = new System.Drawing.Size(797, 341);
            this.tableWebSites.TabIndex = 0;
            this.tableWebSites.TabStop = false;
            this.tableWebSites.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectedRow);
            // 
            // nameWebSite
            // 
            this.nameWebSite.HeaderText = "Наименование сайта";
            this.nameWebSite.Name = "nameWebSite";
            this.nameWebSite.ReadOnly = true;
            this.nameWebSite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nameWebSite.Width = 200;
            // 
            // url
            // 
            this.url.HeaderText = "URL";
            this.url.Name = "url";
            this.url.ReadOnly = true;
            this.url.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.url.Width = 300;
            // 
            // timer
            // 
            this.timer.HeaderText = "Таймер";
            this.timer.Name = "timer";
            this.timer.ReadOnly = true;
            this.timer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Доступность";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutTable);
            this.Controls.Add(this.layoutInput);
            this.MaximizeBox = false;
            this.Name = "View";
            this.ShowIcon = false;
            this.Text = "Monitoring";
            this.Load += new System.EventHandler(this.ViewLoad);
            this.layoutInput.ResumeLayout(false);
            this.layoutInput.PerformLayout();
            this.layoutTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableWebSites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutInput;
        private System.Windows.Forms.FlowLayoutPanel layoutTable;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.DataGridView tableWebSites;
        public System.Windows.Forms.TextBox textNameWebSite;
        public System.Windows.Forms.TextBox textUrlWebSite;
        public System.Windows.Forms.TextBox textTimerWebSite;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameWebSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

