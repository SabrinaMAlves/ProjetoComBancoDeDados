
namespace UC_12_Sabrina_Relac_1000
{
    partial class frm_Vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rELACIONAMENTOS_200DataSet = new UC_12_Sabrina_Relac_1000.RELACIONAMENTOS_200DataSet();
            this.vENDASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENDASTableAdapter = new UC_12_Sabrina_Relac_1000.RELACIONAMENTOS_200DataSetTableAdapters.VENDASTableAdapter();
            this.tableAdapterManager = new UC_12_Sabrina_Relac_1000.RELACIONAMENTOS_200DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.rELACIONAMENTOS_200DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rELACIONAMENTOS_200DataSet
            // 
            this.rELACIONAMENTOS_200DataSet.DataSetName = "RELACIONAMENTOS_200DataSet";
            this.rELACIONAMENTOS_200DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENDASBindingSource
            // 
            this.vENDASBindingSource.DataMember = "VENDAS";
            this.vENDASBindingSource.DataSource = this.rELACIONAMENTOS_200DataSet;
            // 
            // vENDASTableAdapter
            // 
            this.vENDASTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTESTableAdapter = null;
            this.tableAdapterManager.PRODUTOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UC_12_Sabrina_Relac_1000.RELACIONAMENTOS_200DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDASTableAdapter = this.vENDASTableAdapter;
            // 
            // frm_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frm_Vendas";
            this.Text = "frm_Vendas";
            this.Load += new System.EventHandler(this.frm_Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rELACIONAMENTOS_200DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RELACIONAMENTOS_200DataSet rELACIONAMENTOS_200DataSet;
        private System.Windows.Forms.BindingSource vENDASBindingSource;
        private RELACIONAMENTOS_200DataSetTableAdapters.VENDASTableAdapter vENDASTableAdapter;
        private RELACIONAMENTOS_200DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}