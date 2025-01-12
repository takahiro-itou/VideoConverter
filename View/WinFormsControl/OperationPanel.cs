
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
        set { this.m_buttonOrientation = value; }
    }

}

}   //  End of namespace  WinFormsControl
