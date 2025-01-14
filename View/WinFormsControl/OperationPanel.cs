
using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsControl
{

public partial class OperationPanel : UserControl
{
    public OperationPanel()
    {
        InitializeComponent();
    }

    //----------------------------------------------------------------
    /**
    **    ボタンを配置する方向
    **/
    public enum EOrientation
    {
        Horizontal = 0,
        Vertical = 1,
    };

    private  EOrientation   m_buttonOrientation = EOrientation.Horizontal;

    //----------------------------------------------------------------
    /**   Orientation プロパティ
    **
    **/
    [Browsable(true),
    ]
    public EOrientation Orientation
    {
        get { return  this.m_buttonOrientation; }
        set {
            if ( this.m_buttonOrientation == value ) { return; }
            this.m_buttonOrientation = value;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationPanel));
            this.SuspendLayout();
            if ( value == EOrientation.Vertical ) {
                resources.ApplyResources(this, "$OV_this");
            } else {
                resources.ApplyResources(this, "$OH_this");
            }
            this.ResumeLayout(true);
        }
    }

}

}   //  End of namespace  WinFormsControl
