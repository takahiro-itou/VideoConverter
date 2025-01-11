
using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsControl
{

public partial class EncodeConfig : UserControl
{
    public EncodeConfig()
    {
        InitializeComponent();
    }

    //----------------------------------------------------------------
    //    AudioConfigPanel  プロパティ
    //
    [Browsable(true)
    ]
    public AudioConfig AudioConfigPanel
    {
        get { return this.wfcAudio; }
    }

    //----------------------------------------------------------------
    //    VideoConfigPanel  プロパティ
    //
    [Browsable(true)
    ]
    public VideoConfig VideoConfigPanel
    {
        get { return this.wfcVideo; }
    }

}

}   //  End of namespace  WinFormsControl
