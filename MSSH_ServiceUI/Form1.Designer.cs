namespace MSSH_ServiceUI
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new MSSH_ServiceUI.DataSet1();
            this.hostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostsTableAdapter = new MSSH_ServiceUI.DataSet1TableAdapters.hostsTableAdapter();
            this.taskTableAdapter = new MSSH_ServiceUI.DataSet1TableAdapters.taskTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.taskIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onErrorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthCheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskIdDataGridViewTextBoxColumn,
            this.hostDataGridViewTextBoxColumn,
            this.seqDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.paswordDataGridViewTextBoxColumn,
            this.portDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.updateDateDataGridViewTextBoxColumn,
            this.chkDataGridViewTextBoxColumn,
            this.progressDataGridViewTextBoxColumn,
            this.equipNameDataGridViewTextBoxColumn,
            this.outputDataGridViewTextBoxColumn,
            this.onErrorDataGridViewTextBoxColumn,
            this.logTextDataGridViewTextBoxColumn,
            this.logPathDataGridViewTextBoxColumn,
            this.healthCheckDataGridViewTextBoxColumn,
            this.completeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1924, 601);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hostsBindingSource
            // 
            this.hostsBindingSource.DataMember = "task";
            this.hostsBindingSource.DataSource = this.dataSet1;
            // 
            // hostsTableAdapter
            // 
            this.hostsTableAdapter.ClearBeforeFill = true;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "task_hosts";
            this.bindingSource1.DataSource = this.hostsBindingSource;
            // 
            // taskIdDataGridViewTextBoxColumn
            // 
            this.taskIdDataGridViewTextBoxColumn.DataPropertyName = "taskId";
            this.taskIdDataGridViewTextBoxColumn.HeaderText = "taskId";
            this.taskIdDataGridViewTextBoxColumn.Name = "taskIdDataGridViewTextBoxColumn";
            // 
            // hostDataGridViewTextBoxColumn
            // 
            this.hostDataGridViewTextBoxColumn.DataPropertyName = "host";
            this.hostDataGridViewTextBoxColumn.HeaderText = "host";
            this.hostDataGridViewTextBoxColumn.Name = "hostDataGridViewTextBoxColumn";
            // 
            // seqDataGridViewTextBoxColumn
            // 
            this.seqDataGridViewTextBoxColumn.DataPropertyName = "seq";
            this.seqDataGridViewTextBoxColumn.HeaderText = "seq";
            this.seqDataGridViewTextBoxColumn.Name = "seqDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "userId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // paswordDataGridViewTextBoxColumn
            // 
            this.paswordDataGridViewTextBoxColumn.DataPropertyName = "pasword";
            this.paswordDataGridViewTextBoxColumn.HeaderText = "pasword";
            this.paswordDataGridViewTextBoxColumn.Name = "paswordDataGridViewTextBoxColumn";
            // 
            // portDataGridViewTextBoxColumn
            // 
            this.portDataGridViewTextBoxColumn.DataPropertyName = "port";
            this.portDataGridViewTextBoxColumn.HeaderText = "port";
            this.portDataGridViewTextBoxColumn.Name = "portDataGridViewTextBoxColumn";
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "createDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "createDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            // 
            // updateDateDataGridViewTextBoxColumn
            // 
            this.updateDateDataGridViewTextBoxColumn.DataPropertyName = "updateDate";
            this.updateDateDataGridViewTextBoxColumn.HeaderText = "updateDate";
            this.updateDateDataGridViewTextBoxColumn.Name = "updateDateDataGridViewTextBoxColumn";
            // 
            // chkDataGridViewTextBoxColumn
            // 
            this.chkDataGridViewTextBoxColumn.DataPropertyName = "chk";
            this.chkDataGridViewTextBoxColumn.HeaderText = "chk";
            this.chkDataGridViewTextBoxColumn.Name = "chkDataGridViewTextBoxColumn";
            // 
            // progressDataGridViewTextBoxColumn
            // 
            this.progressDataGridViewTextBoxColumn.DataPropertyName = "progress";
            this.progressDataGridViewTextBoxColumn.HeaderText = "progress";
            this.progressDataGridViewTextBoxColumn.Name = "progressDataGridViewTextBoxColumn";
            // 
            // equipNameDataGridViewTextBoxColumn
            // 
            this.equipNameDataGridViewTextBoxColumn.DataPropertyName = "equipName";
            this.equipNameDataGridViewTextBoxColumn.HeaderText = "equipName";
            this.equipNameDataGridViewTextBoxColumn.Name = "equipNameDataGridViewTextBoxColumn";
            // 
            // outputDataGridViewTextBoxColumn
            // 
            this.outputDataGridViewTextBoxColumn.DataPropertyName = "output";
            this.outputDataGridViewTextBoxColumn.HeaderText = "output";
            this.outputDataGridViewTextBoxColumn.Name = "outputDataGridViewTextBoxColumn";
            // 
            // onErrorDataGridViewTextBoxColumn
            // 
            this.onErrorDataGridViewTextBoxColumn.DataPropertyName = "onError";
            this.onErrorDataGridViewTextBoxColumn.HeaderText = "onError";
            this.onErrorDataGridViewTextBoxColumn.Name = "onErrorDataGridViewTextBoxColumn";
            // 
            // logTextDataGridViewTextBoxColumn
            // 
            this.logTextDataGridViewTextBoxColumn.DataPropertyName = "logText";
            this.logTextDataGridViewTextBoxColumn.HeaderText = "logText";
            this.logTextDataGridViewTextBoxColumn.Name = "logTextDataGridViewTextBoxColumn";
            // 
            // logPathDataGridViewTextBoxColumn
            // 
            this.logPathDataGridViewTextBoxColumn.DataPropertyName = "logPath";
            this.logPathDataGridViewTextBoxColumn.HeaderText = "logPath";
            this.logPathDataGridViewTextBoxColumn.Name = "logPathDataGridViewTextBoxColumn";
            // 
            // healthCheckDataGridViewTextBoxColumn
            // 
            this.healthCheckDataGridViewTextBoxColumn.DataPropertyName = "healthCheck";
            this.healthCheckDataGridViewTextBoxColumn.HeaderText = "healthCheck";
            this.healthCheckDataGridViewTextBoxColumn.Name = "healthCheckDataGridViewTextBoxColumn";
            // 
            // completeDataGridViewTextBoxColumn
            // 
            this.completeDataGridViewTextBoxColumn.DataPropertyName = "complete";
            this.completeDataGridViewTextBoxColumn.HeaderText = "complete";
            this.completeDataGridViewTextBoxColumn.Name = "completeDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 601);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource hostsBindingSource;
        private DataSet1TableAdapters.hostsTableAdapter hostsTableAdapter;
        private DataSet1TableAdapters.taskTableAdapter taskTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn progressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onErrorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthCheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completeDataGridViewTextBoxColumn;
    }
}

