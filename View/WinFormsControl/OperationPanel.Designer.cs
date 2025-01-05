
namespace WinFormsControl
{

partial class OperationPanel
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationPanel));
        btnAdd = new Button();
        btnRemove = new Button();
        btnClear = new Button();
        btnRun = new Button();
        this.SuspendLayout();

        //
        // btnAdd
        //
        resources.ApplyResources(btnAdd, "btnAdd");
        btnAdd.Name = "btnAdd";
        btnAdd.UseVisualStyleBackColor = true;
        //
        // btnRemove
        //
        resources.ApplyResources(btnRemove, "btnRemove");
        btnRemove.Name = "btnRemove";
        btnRemove.UseVisualStyleBackColor = true;
        //
        // btnClear
        //
        resources.ApplyResources(btnClear, "btnClear");
        btnClear.Name = "btnClear";
        btnClear.UseVisualStyleBackColor = true;
        //
        // btnRun
        //
        resources.ApplyResources(btnRun, "btnRun");
        btnRun.Name = "btnRun";
        btnRun.UseVisualStyleBackColor = true;
        //
        // OperationPanel
        //
        this.AutoScaleMode = AutoScaleMode.None;
        this.BorderStyle = BorderStyle.FixedSingle;
        Controls.Add(btnAdd);
        Controls.Add(btnRemove);
        Controls.Add(btnClear);
        Controls.Add(btnRun);
        resources.ApplyResources(this, "$this");
        this.Name = "OperationPanel";
        this.ResumeLayout(false);
    }

    #endregion

    private Button btnAdd;
    private Button btnRemove;
    private Button btnClear;
    private Button btnRun;
}

}   //  End of namespace  WinFormsControl
