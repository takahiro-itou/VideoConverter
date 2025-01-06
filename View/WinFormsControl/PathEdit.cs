
using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsControl
{

public partial class PathEdit : UserControl
{
    public PathEdit()
    {
        InitializeComponent();
    }

    /**
    **    参照ボタンを押した時に表示するダイアログの種類
    **/
    public enum EDialogType
    {
        Folder = 0,     /**<  フォルダ          **/
        OpenFile = 1,   /**<  ファイルを開く    **/
        SaveFile = 2,   /**<  名前を付けて保存  **/
    };

    private EDialogType m_dialogType    = DialogType.Folder;

    //----------------------------------------------------------------
    //    DialogType  プロパティ
    //
    [Browsable(true)
      , Description("ダイアログの種類を切り替える")
      , Category("動作")
    ]
    public EDialogType DialogType
    {
        get { return  this.m_dialogType; }
        set { this.m_dialogType = value; }
    }

}

}   //  End of namespace  WinFormsControl
