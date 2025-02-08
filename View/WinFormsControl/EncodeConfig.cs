//  -*-  coding: utf-8-with-signature;  mode: c++  -*-  //
/*************************************************************************
**                                                                      **
**                      ---  Video Converter.  ---                      **
**                                                                      **
**          Copyright (C), 2024-2025, Takahiro Itou                     **
**          All Rights Reserved.                                        **
**                                                                      **
**          License: (See COPYING or LICENSE files)                     **
**          GNU Affero General Public License (AGPL) version 3,         **
**          or (at your option) any later version.                      **
**                                                                      **
*************************************************************************/

/**
**      An Implementation of EncodeConfig class.
**
**      @file       EncodeConfig.Designer.cs
**/

using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsControl
{

//========================================================================
//
//    EncodeConfig  class.
//

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
