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
**      An Implementation of AudioConfig class.
**
**      @file       AudioConfig.Designer.cs
**/

namespace WinFormsControl
{

//========================================================================
//
//    AudioConfig  class.
//

partial class AudioConfig
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
                new System.ComponentModel.ComponentResourceManager(typeof(AudioConfig));

        fraAudioConfig = new GroupBox();
        spcAudioConfig = new SplitContainer();
        lblChannel = new Label();
        cmbChannels = new ComboBox();
        lblVolume = new Label();
        cmbVolume = new ComboBox();
        lblDelay = new Label();
        cmbAudioDelay = new ComboBox();
        lblCodec = new Label();
        cmbCodec = new ComboBox();
        lblSampleRate = new Label();
        cmbSampleRate = new ComboBox();
        lblBitRate = new Label();
        cmbBitRate = new ComboBox();

        ((System.ComponentModel.ISupportInitialize)spcAudioConfig).BeginInit();
        spcAudioConfig.Panel1.SuspendLayout();
        spcAudioConfig.Panel2.SuspendLayout();
        spcAudioConfig.SuspendLayout();
        fraAudioConfig.SuspendLayout();
        this.SuspendLayout();

        //
        //  fraAudioConfig
        //
        resources.ApplyResources(fraAudioConfig, "fraAudioConfig");
        fraAudioConfig.Controls.Add(spcAudioConfig);
        fraAudioConfig.Name = "fraAudioConfig";
        fraAudioConfig.TabStop = false;
        //
        //  spcAudioConfig
        //
        resources.ApplyResources(spcAudioConfig, "spcAudioConfig");
        spcAudioConfig.Name = "spcAudioConfig";
        //
        //  spcAudioConfig.Panel1
        //
        spcAudioConfig.Panel1.Controls.Add(lblChannel);
        spcAudioConfig.Panel1.Controls.Add(cmbChannels);
        spcAudioConfig.Panel1.Controls.Add(lblVolume);
        spcAudioConfig.Panel1.Controls.Add(cmbVolume);
        spcAudioConfig.Panel1.Controls.Add(lblDelay);
        spcAudioConfig.Panel1.Controls.Add(cmbAudioDelay);
        //
        //  spcAudioConfig.Panel2
        //
        spcAudioConfig.Panel2.Controls.Add(lblCodec);
        spcAudioConfig.Panel2.Controls.Add(cmbCodec);
        spcAudioConfig.Panel2.Controls.Add(lblSampleRate);
        spcAudioConfig.Panel2.Controls.Add(cmbSampleRate);
        spcAudioConfig.Panel2.Controls.Add(lblBitRate);
        spcAudioConfig.Panel2.Controls.Add(cmbBitRate);

        //
        //  lblChannel
        //
        resources.ApplyResources(lblChannel, "lblChannel");
        lblChannel.Name = "lblChannel";
        //
        //  cmbChannels
        //
        resources.ApplyResources(cmbChannels, "cmbChannels");
        cmbChannels.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbChannels.FormattingEnabled = true;
        cmbChannels.Name = "cmbChannels";
        //
        //  lblVolume
        //
        resources.ApplyResources(lblVolume, "lblVolume");
        lblVolume.Name = "lblVolume";
        //
        //  cmbVolume
        //
        resources.ApplyResources(cmbVolume, "cmbVolume");
        cmbVolume.FormattingEnabled = true;
        cmbVolume.Name = "cmbVolume";
        //
        //  lblDelay
        //
        resources.ApplyResources(lblDelay, "lblDelay");
        lblDelay.Name = "lblDelay";
        //
        //  cmbAudioDelay
        //
        resources.ApplyResources(cmbAudioDelay, "cmbAudioDelay");
        cmbAudioDelay.FormattingEnabled = true;
        cmbAudioDelay.Name = "cmbAudioDelay";

        //
        //  lblCodec
        //
        resources.ApplyResources(lblCodec, "lblCodec");
        lblCodec.Name = "lblCodec";
        //
        //  cmbCodec
        //
        resources.ApplyResources(cmbCodec, "cmbCodec");
        cmbCodec.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCodec.FormattingEnabled = true;
        cmbCodec.Name = "cmbCodec";
        //
        //  lblSampleRate
        //
        resources.ApplyResources(lblSampleRate, "lblSampleRate");
        lblSampleRate.Name = "lblSampleRate";
        //
        //  cmbSampleRate
        //
        resources.ApplyResources(cmbSampleRate, "cmbSampleRate");
        cmbSampleRate.FormattingEnabled = true;
        cmbSampleRate.Name = "cmbSampleRate";
        //
        //  lblBitRate
        //
        resources.ApplyResources(lblBitRate, "lblBitRate");
        lblBitRate.Name = "lblBitRate";
        //
        //  cmbBitRate
        //
        resources.ApplyResources(cmbBitRate, "cmbBitRate");
        cmbBitRate.FormattingEnabled = true;
        cmbBitRate.Name = "cmbBitRate";

        //
        //  AudioConfig
        //
        AutoScaleMode = AutoScaleMode.None;
        Controls.Add(fraAudioConfig);
        resources.ApplyResources(this, "$this");
        Name = "AudioConfig";

        spcAudioConfig.Panel1.ResumeLayout(false);
        spcAudioConfig.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)spcAudioConfig).EndInit();
        spcAudioConfig.ResumeLayout(false);
        fraAudioConfig.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private GroupBox fraAudioConfig;
    private SplitContainer spcAudioConfig;
    private Label lblChannel;
    private ComboBox cmbChannels;
    private Label lblVolume;
    private ComboBox cmbVolume;
    private Label lblDelay;
    private ComboBox cmbAudioDelay;
    private Label lblCodec;
    private ComboBox cmbCodec;
    private Label lblSampleRate;
    private ComboBox cmbSampleRate;
    private Label lblBitRate;
    private ComboBox cmbBitRate;
}

}   //  End of namespace  WinFormsControl
