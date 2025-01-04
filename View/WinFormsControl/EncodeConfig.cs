
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
    //    AudioConfig プロパティ
    //
    [Browsable(true)
    ]
    public AudioConfig AudioConfig
    {
        get { return this.wfcAudio; }
    }

    //----------------------------------------------------------------
    //    VideoConfig プロパティ
    //
    [Browsable(true)
    ]
    public VideoConfig VideoConfig
    {
        get { return this.wfcVideo; }
    }

}

}   //  End of namespace  WinFormsControl
