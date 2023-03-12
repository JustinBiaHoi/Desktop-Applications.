namespace BaiTapLyThuyet2
{
    partial class Img_Collector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Img_Collector));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "326310281_704453821263215_7779370682314772788_n.jpg");
            this.imageList1.Images.SetKeyName(1, "324187682_1401971467284772_7396630479970102821_n.jpg");
            this.imageList1.Images.SetKeyName(2, "326769348_1133877087322487_635514693060260981_n.jpg");
            this.imageList1.Images.SetKeyName(3, "325914262_1586897195159742_287913761568171920_n.jpg");
            this.imageList1.Images.SetKeyName(4, "325419467_1527275307753682_1777132160080313738_n.jpg");
            // 
            // Img_Collector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Img_Collector";
            this.Text = "Img_Collector";
            this.Load += new System.EventHandler(this.Img_Collector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
    }
}