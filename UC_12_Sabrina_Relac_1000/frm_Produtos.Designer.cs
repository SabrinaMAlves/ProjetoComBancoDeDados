
namespace UC_12_Sabrina_Relac_1000
{
    partial class frm_Produtos
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
            this.pRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOSTableAdapter = new UC_12_Sabrina_Relac_1000.RELACIONAMENTOS_200DataSetTableAdapters.PRODUTOSTableAdapter();
            this.tableAdapterManager = new UC_12_Sabrina_Relac_1000.RELACIONAMENTOS_200DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.rELACIONAMENTOS_200DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rELACIONAMENTOS_200DataSet
            // 
            this.rELACIONAMENTOS_200DataSet.DataSetName = "RELACIONAMENTOS_200DataSet";
            this.rELACIONAMENTOS_200DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUTOSBindingSource
            // 
            this.pRODUTOSBindingSource.DataMember = "PRODUTOS";
            this.pRODUTOSBindingSource.DataSource = this.rELACIONAMENTOS_200DataSet;
            // 
            // pRODUTOSTableAdapter
            // 
            this.pRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTESTableAdapter = null;
            this.tableAdapterManager.PRODUTOSTableAdapter = this.pRODUTOSTableAdapter;
            this.tableAdapterManager.UpdateOrder = UC_12_Sabrina_Relac_1000.RELACIONAMENTOS_200DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDASTableAdapter = null;
            // 
            // frm_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frm_Produtos";
            this.Text = "frm_Produtos";
            this.Load += new System.EventHandler(this.frm_Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rELACIONAMENTOS_200DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RELACIONAMENTOS_200DataSet rELACIONAMENTOS_200DataSet;
        private System.Windows.Forms.BindingSource pRODUTOSBindingSource;
        private RELACIONAMENTOS_200DataSetTableAdapters.PRODUTOSTableAdapter pRODUTOSTableAdapter;
        private RELACIONAMENTOS_200DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}