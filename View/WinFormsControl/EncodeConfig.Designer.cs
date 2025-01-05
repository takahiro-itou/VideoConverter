
namespace WinFormsControl
{

partial class EncodeConfig
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncodeConfig));

        Label1 = new Label();
        cmbPreset = new ComboBox();
        wfcVideo = new VideoConfig();
        wfcAudio = new AudioConfig();
        this.SuspendLayout();

        //
        // Label1
        //
        resources.ApplyResources(Label1, "Label1");
        Label1.Name = "Label1";
        //
        // cmbPreset
        //
        cmbPreset.FormattingEnabled = true;
        resources.ApplyResources(cmbPreset, "cmbPreset");
        cmbPreset.Name = "cmbPreset";
        //
        // wfcVideo
        //
        resources.ApplyResources(wfcVideo, "wfcVideo");
        wfcVideo.Name = "wfcVideo";
        //
        // wfcAudio
        //
        resources.ApplyResources(wfcAudio, "wfcAudio");
        wfcAudio.Name = "wfcAudio";
        //
        // EncodeConfig
        //
        this.AutoScaleMode = AutoScaleMode.None;
        this.Controls.Add(Label1);
        this.Controls.Add(cmbPreset);
        this.Controls.Add(wfcVideo);
        this.Controls.Add(wfcAudio);
        resources.ApplyResources(this, "$this");
        this.Name = "EncodeConfig";
        this.ResumeLayout(false);
    }

    #endregion

    private Label Label1;
    private ComboBox cmbPreset;
    private VideoConfig wfcVideo;
    private AudioConfig wfcAudio;
}

}   //  End of namespace  WinFormsControl
