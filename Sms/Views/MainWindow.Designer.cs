namespace Sms.Views
{
    partial class MainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TableLayoutPanelHorizontal = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelVertical = new System.Windows.Forms.TableLayoutPanel();
            this.DictionaryDataGridView = new System.Windows.Forms.DataGridView();
            this.TableLayoutPanelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DictionaryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanelHorizontal
            // 
            this.TableLayoutPanelHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanelHorizontal.ColumnCount = 2;
            this.TableLayoutPanelHorizontal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.37433F));
            this.TableLayoutPanelHorizontal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.62567F));
            this.TableLayoutPanelHorizontal.Controls.Add(this.TableLayoutPanelVertical, 0, 0);
            this.TableLayoutPanelHorizontal.Controls.Add(this.DictionaryDataGridView, 1, 0);
            this.TableLayoutPanelHorizontal.Location = new System.Drawing.Point(-1, 0);
            this.TableLayoutPanelHorizontal.Name = "TableLayoutPanelHorizontal";
            this.TableLayoutPanelHorizontal.RowCount = 1;
            this.TableLayoutPanelHorizontal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelHorizontal.Size = new System.Drawing.Size(935, 512);
            this.TableLayoutPanelHorizontal.TabIndex = 0;
            // 
            // TableLayoutPanelVertical
            // 
            this.TableLayoutPanelVertical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanelVertical.ColumnCount = 1;
            this.TableLayoutPanelVertical.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelVertical.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanelVertical.Name = "TableLayoutPanelVertical";
            this.TableLayoutPanelVertical.RowCount = 2;
            this.TableLayoutPanelVertical.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelVertical.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelVertical.Size = new System.Drawing.Size(651, 506);
            this.TableLayoutPanelVertical.TabIndex = 0;
            // 
            // DictionaryDataGridView
            // 
            this.DictionaryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DictionaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DictionaryDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.DictionaryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DictionaryDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DictionaryDataGridView.Location = new System.Drawing.Point(660, 3);
            this.DictionaryDataGridView.MultiSelect = false;
            this.DictionaryDataGridView.Name = "DictionaryDataGridView";
            this.DictionaryDataGridView.ShowCellErrors = false;
            this.DictionaryDataGridView.Size = new System.Drawing.Size(272, 506);
            this.DictionaryDataGridView.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 510);
            this.Controls.Add(this.TableLayoutPanelHorizontal);
            this.Name = "MainWindow";
            this.Text = "Sms";
            this.TableLayoutPanelHorizontal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DictionaryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelHorizontal;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelVertical;
        private System.Windows.Forms.DataGridView DictionaryDataGridView;
    }
}