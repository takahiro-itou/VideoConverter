
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

    //----------------------------------------------------------------
    /**
    **    参照ボタンを押した時に表示するダイアログの種類
    **/
    public enum EDialogType
    {
        Folder = 0,     /**<  フォルダ          **/
        OpenFile = 1,   /**<  ファイルを開く    **/
        SaveFile = 2,   /**<  名前を付けて保存  **/
    };

    private EDialogType m_dialogType    = EDialogType.Folder;

    //----------------------------------------------------------------
    /**   フォルダ検索ダイアログを起動する
    **
    **/
    public boolean openFolderDialog(
            System.String description,
            System.String initialDir)
    {
        using (var dlg = new FolderBrowserDialog()) {
            dlg.Description = description;
            dlg.SelectedPath = initialDir;
            if ( dlg.ShowDialog() != DialogResult.OK ) {
                return  false;
            }
            cmbPath.Text = dlg.SelectedPath;
        }
        return  true;
    }

    //----------------------------------------------------------------
    /**   DialogType  プロパティ
    **
    **/
    [Browsable(true)
      , Description("ダイアログの種類を切り替える")
      , Category("動作")
    ]
    public EDialogType DialogType
    {
        get { return  this.m_dialogType; }
        set { this.m_dialogType = value; }
    }

    //----------------------------------------------------------------
    /**   PathEditBox プロパティ
    **
    **/
    [Browsable(true)
    ]
    public ComboBox PathEditBox
    {
        get { return  this.cmbPath; }
    }

    //----------------------------------------------------------------
    /**   PathChanged イベント
    **
    **/
    [Browsable(true)
      , Description("パスが変更された時に発生するイベントです")
      , Category("プロパティ変更")
    ]
    public event EventHandler<EventArgs>? PathChanged;

    //----------------------------------------------------------------
    /**   イベントハンドラを呼び出すメソッド
    **
    **/
    protected virtual void OnPathCahnged(System.EventArgs e
    {
        var eventHandler = PathChanged;
        if ( eventHandler != null ) {
            eventHandler(this, e);
        }
    }

    //----------------------------------------------------------------
    /**   イベントハンドラ
    **
    **    「参照」ボタンのクリックイベント
    **/
    private void btnRefer_Click(object sender, System.EventArgs e)
    {
        if ( this.m_dialogType == EDialogType.Folder ) {
            openFolderDialog("Select Folder", cmbPath.Text);
        }
    }

}

}   //  End of namespace  WinFormsControl
