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
            this.TableLayoutPanelHorizontal = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelVertical = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelHorizontal.SuspendLayout();
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 510);
            this.Controls.Add(this.TableLayoutPanelHorizontal);
            this.Name = "MainWindow";
            this.Text = "Sms";
            this.TableLayoutPanelHorizontal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelHorizontal;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelVertical;
    }
}