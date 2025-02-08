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

namespace WinFormsControl
{

//========================================================================
//
//    EncodeConfig  class.
//

partial class EncodeConfig
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
        System.ComponentModel.ComponentResourceManager resources =
                new ComponentResourceManager(typeof(EncodeConfig));

        Label1 = new Label();
        wfcPath = new PathEdit();
        Label2 = new Label();
        cmbPreset = new ComboBox();
        wfcVideo = new VideoConfig();
        wfcAudio = new AudioConfig();
        this.SuspendLayout();

        //
        //  Label1
        //
        resources.ApplyResources(Label1, "Label1");
        Label1.Name = "Label1";
        //
        //  wfcPath
        //
        resources.ApplyResources(wfcPath, "wfcPath");
        wfcPath.Name = "wfcPath";
        //
        //  Label2
        //
        resources.ApplyResources(Label2, "Label2");
        Label2.Name = "Label2";
        //
        //  cmbPreset
        //
        cmbPreset.FormattingEnabled = true;
        resources.ApplyResources(cmbPreset, "cmbPreset");
        cmbPreset.Name = "cmbPreset";
        //
        //  wfcVideo
        //
        resources.ApplyResources(wfcVideo, "wfcVideo");
        wfcVideo.Name = "wfcVideo";
        //
        //  wfcAudio
        //
        resources.ApplyResources(wfcAudio, "wfcAudio");
        wfcAudio.Name = "wfcAudio";

        //
        //  EncodeConfig
        //
        this.AutoScaleMode = AutoScaleMode.None;
        this.Controls.Add(Label1);
        this.Controls.Add(wfcPath);
        this.Controls.Add(Label2);
        this.Controls.Add(cmbPreset);
        this.Controls.Add(wfcVideo);
        this.Controls.Add(wfcAudio);
        resources.ApplyResources(this, "$this");
        this.Name = "EncodeConfig";
        this.ResumeLayout(false);
    }

    #endregion

    private Label Label1;
    private PathEdit wfcPath;
    private Label Label2;
    private ComboBox cmbPreset;
    private VideoConfig wfcVideo;
    private AudioConfig wfcAudio;
}

}   //  End of namespace  WinFormsControl
