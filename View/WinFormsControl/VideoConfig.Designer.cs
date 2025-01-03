
namespace WinFormsControl
{

partial class VideoConfig
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoConfig));

        fraVideConfig = new GroupBox();
        spcVideoConfig = new SplitContainer();
        lblFormat = new Label();
        cmbFormat = new ComboBox();
        lblSize = new Label();
        cmbSize = new ComboBox();
        lblAspect = new Label();
        cmbAspect = new ComboBox();
        lblCodec = new Label();
        cmbCodec = new ComboBox();
        lblFrameRate = new Label();
        cmbFrameRate = new ComboBox();
        lblBitRate = new Label();
        cmbBitRate = new ComboBox();

        ((System.ComponentModel.ISupportInitialize)spcVideoConfig).BeginInit();
        spcVideoConfig.Panel1.SuspendLayout();
        spcVideoConfig.Panel2.SuspendLayout();
        spcVideoConfig.SuspendLayout();
        fraVideConfig.SuspendLayout();
        this.SuspendLayout();

        //
        // fraVideConfig
        //
        resources.ApplyResources(fraVideConfig, "fraVideConfig");
        fraVideConfig.Controls.Add(spcVideoConfig);
        fraVideConfig.Name = "fraVideConfig";
        fraVideConfig.TabStop = false;

        //
        // spcVideoConfig
        //
        resources.ApplyResources(spcVideoConfig, "spcVideoConfig");
        spcVideoConfig.Name = "spcVideoConfig";
        //
        // spcVideoConfig.Panel1
        //
        spcVideoConfig.Panel1.Controls.Add(lblFormat);
        spcVideoConfig.Panel1.Controls.Add(cmbFormat);
        spcVideoConfig.Panel1.Controls.Add(lblSize);
        spcVideoConfig.Panel1.Controls.Add(cmbSize);
        spcVideoConfig.Panel1.Controls.Add(lblAspect);
        spcVideoConfig.Panel1.Controls.Add(cmbAspect);
        //
        // spcVideoConfig.Panel2
        //
        spcVideoConfig.Panel2.Controls.Add(lblCodec);
        spcVideoConfig.Panel2.Controls.Add(cmbCodec);
        spcVideoConfig.Panel2.Controls.Add(lblFrameRate);
        spcVideoConfig.Panel2.Controls.Add(cmbFrameRate);
        spcVideoConfig.Panel2.Controls.Add(lblBitRate);
        spcVideoConfig.Panel2.Controls.Add(cmbBitRate);

        //
        // cmbFormat
        //
        resources.ApplyResources(cmbFormat, "cmbFormat");
        cmbFormat.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbFormat.FormattingEnabled = true;
        cmbFormat.Name = "cmbFormat";
        //
        // lblFormat
        //
        resources.ApplyResources(lblFormat, "lblFormat");
        lblFormat.Name = "lblFormat";
        //
        // lblSize
        //
        resources.ApplyResources(lblSize, "lblSize");
        lblSize.Name = "lblSize";
        //
        // cmbSize
        //
        resources.ApplyResources(cmbSize, "cmbSize");
        cmbSize.FormattingEnabled = true;
        cmbSize.Name = "cmbSize";
        //
        // lblAspect
        //
        resources.ApplyResources(lblAspect, "lblAspect");
        lblAspect.Name = "lblAspect";
        //
        // cmbAspect
        //
        resources.ApplyResources(cmbAspect, "cmbAspect");
        cmbAspect.FormattingEnabled = true;
        cmbAspect.Name = "cmbAspect";

        //
        // lblCodec
        //
        resources.ApplyResources(lblCodec, "lblCodec");
        lblCodec.Name = "lblCodec";
        //
        // cmbCodec
        //
        resources.ApplyResources(cmbCodec, "cmbCodec");
        cmbCodec.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCodec.FormattingEnabled = true;
        cmbCodec.Name = "cmbCodec";

        //
        // lblFrameRate
        //
        resources.ApplyResources(lblFrameRate, "lblFrameRate");
        lblFrameRate.Name = "lblFrameRate";
        //
        // cmbFrameRate
        //
        resources.ApplyResources(cmbFrameRate, "cmbFrameRate");
        cmbFrameRate.FormattingEnabled = true;
        cmbFrameRate.Name = "cmbFrameRate";
        //
        // lblBitRate
        //
        resources.ApplyResources(lblBitRate, "lblBitRate");
        lblBitRate.Name = "lblBitRate";
        //
        // cmbBitRate
        //
        resources.ApplyResources(cmbBitRate, "cmbBitRate");
        cmbBitRate.FormattingEnabled = true;
        cmbBitRate.Name = "cmbBitRate";

        //
        // VideoConfig
        //
        AutoScaleMode = AutoScaleMode.None;
        Controls.Add(fraVideConfig);
        resources.ApplyResources(this, "$this");
        Name = "VideoConfig";

        spcVideoConfig.Panel1.ResumeLayout(false);
        spcVideoConfig.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)spcVideoConfig).EndInit();
        spcVideoConfig.ResumeLayout(false);
        fraVideConfig.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private GroupBox fraVideConfig;
    private SplitContainer spcVideoConfig;
    private Label lblFormat;
    private ComboBox cmbFormat;
    private Label lblSize;
    private ComboBox cmbSize;
    private Label lblAspect;
    private ComboBox cmbAspect;

    private Label lblCodec;
    private ComboBox cmbCodec;
    private Label lblFrameRate;
    private ComboBox cmbFrameRate;
    private Label lblBitRate;
    private ComboBox cmbBitRate;
}

}   //  End of namespace  WinFormsControl
