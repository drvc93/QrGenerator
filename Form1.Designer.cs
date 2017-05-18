namespace QrGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gvCodigos = new DevExpress.XtraGrid.GridControl();
            this.gvCodigosLista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btnAddCod = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvCodigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCodigosLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(558, 211);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // gvCodigos
            // 
            this.gvCodigos.Location = new System.Drawing.Point(12, 61);
            this.gvCodigos.MainView = this.gvCodigosLista;
            this.gvCodigos.Name = "gvCodigos";
            this.gvCodigos.Size = new System.Drawing.Size(526, 221);
            this.gvCodigos.TabIndex = 1;
            this.gvCodigos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCodigosLista});
            // 
            // gvCodigosLista
            // 
            this.gvCodigosLista.GridControl = this.gvCodigos;
            this.gvCodigosLista.Name = "gvCodigosLista";
            this.gvCodigosLista.OptionsView.ShowGroupPanel = false;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(12, 35);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(280, 22);
            this.txtCod.TabIndex = 2;
            // 
            // btnAddCod
            // 
            this.btnAddCod.Location = new System.Drawing.Point(305, 34);
            this.btnAddCod.Name = "btnAddCod";
            this.btnAddCod.Size = new System.Drawing.Size(75, 23);
            this.btnAddCod.TabIndex = 3;
            this.btnAddCod.Text = "Agregar";
            this.btnAddCod.Click += new System.EventHandler(this.btnAddCod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 294);
            this.Controls.Add(this.btnAddCod);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.gvCodigos);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvCodigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCodigosLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private DevExpress.XtraGrid.GridControl gvCodigos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCodigosLista;
        private System.Windows.Forms.TextBox txtCod;
        private DevExpress.XtraEditors.SimpleButton btnAddCod;
    }
}

