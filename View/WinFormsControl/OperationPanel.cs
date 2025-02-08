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
**      An Implementation of OperationPanel class.
**
**      @file       OperationPanel.cs
**/

using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsControl
{

//========================================================================
//
//    OperationPanel  class.
//

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
            ComponentResourceManager resources
                = new ComponentResourceManager(typeof(OperationPanel));
            this.SuspendLayout();
            if ( value == EOrientation.Vertical ) {
                resources.ApplyResources(this.btnAdd, "OV_btnAdd");
                resources.ApplyResources(this.btnRemove, "OV_btnRemove");
                resources.ApplyResources(this.btnClear, "OV_btnClear");
                resources.ApplyResources(this.btnRun, "OV_btnRun");
                resources.ApplyResources(this, "OV_$this");
            } else {
                resources.ApplyResources(this.btnAdd, "OH_btnAdd");
                resources.ApplyResources(this.btnRemove, "OH_btnRemove");
                resources.ApplyResources(this.btnClear, "OH_btnClear");
                resources.ApplyResources(this.btnRun, "OH_btnRun");
                resources.ApplyResources(this, "OH_$this");
            }
            this.ResumeLayout(false);
            this.PerformLayout  ();
        }
    }

}

}   //  End of namespace  WinFormsControl
