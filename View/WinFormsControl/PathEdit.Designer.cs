
namespace WinFormsControl
{

partial class PathEdit
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Component Designer generated code

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PathEdit));
        cmbPath = new ComboBox();
        btnRefer = new Button();
        dlgFolder = new FolderBrowserDialog();
        dlgOpen = new OpenFileDialog();
        dlgSave = new SaveFileDialog();
        this.SuspendLayout();

        //
        //  cmbPath
        //
        resources.ApplyResources(cmbPath, "cmbPath");
        cmbPath.FormattingEnabled = true;
        cmbPath.Name = "cmbPath";
        //
        //  btnRefer
        //
        resources.ApplyResources(btnRefer, "btnRefer");
        btnRefer.Name = "btnRefer";
        btnRefer.UseVisualStyleBackColor = true;
        btnRefer.Click += btnRefer_Click;

        //
        //  dlgFolder
        //
        resources.ApplyResources(dlgFolder, "dlgFolder");
        //
        //  dlgOpen
        //
        resources.ApplyResources(dlgOpen, "dlgOpen");
        //
        //  dlgSave
        //
        resources.ApplyResources(dlgSave, "dlgSave");

        //
        //  PathEdit
        //
        this.AllowDrop = true;
        this.AutoScaleMode = AutoScaleMode.None;
        this.Controls.Add(cmbPath);
        this.Controls.Add(btnRefer);
        resources.ApplyResources(this, "$this");
        this.Name = "PathEdit";
        this.ResumeLayout(false);
    }

    #endregion
    private ComboBox cmbPath;
    private Button btnRefer;
    private FolderBrowserDialog dlgFolder;
    private OpenFileDialog dlgOpen;
    private SaveFileDialog dlgSave;
}

}   //  End of namespace  WinFormsControl
