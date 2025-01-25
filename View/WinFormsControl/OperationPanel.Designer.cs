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
**      @file       OperationPanel.Designer.cs
**/

using System.ComponentModel;

namespace WinFormsControl
{

//========================================================================
//
//    OperationPanel  class.
//

partial class OperationPanel
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
                new ComponentResourceManager(typeof(OperationPanel));
        btnAdd = new Button();
        btnRemove = new Button();
        btnClear = new Button();
        btnRun = new Button();
        this.SuspendLayout();

        //
        //  btnAdd
        //
        resources.ApplyResources(btnAdd, "btnAdd");
        resources.ApplyResources(btnAdd, "OH_btnAdd");
        btnAdd.Name = "btnAdd";
        btnAdd.UseVisualStyleBackColor = true;
        //
        //  btnRemove
        //
        resources.ApplyResources(btnRemove, "btnRemove");
        resources.ApplyResources(btnRemove, "OH_btnRemove");
        btnRemove.Name = "btnRemove";
        btnRemove.UseVisualStyleBackColor = true;
        //
        //  btnClear
        //
        resources.ApplyResources(btnClear, "btnClear");
        resources.ApplyResources(btnClear, "OH_btnClear");
        btnClear.Name = "btnClear";
        btnClear.UseVisualStyleBackColor = true;
        //
        //  btnRun
        //
        resources.ApplyResources(btnRun, "btnRun");
        resources.ApplyResources(btnRun, "OH_btnRun");
        btnRun.Name = "btnRun";
        btnRun.UseVisualStyleBackColor = true;
        //
        //  OperationPanel
        //
        this.AutoScaleMode = AutoScaleMode.None;
        this.BorderStyle = BorderStyle.FixedSingle;
        this.Controls.Add(btnAdd);
        this.Controls.Add(btnRemove);
        this.Controls.Add(btnClear);
        this.Controls.Add(btnRun);
        resources.ApplyResources(this, "$this");
        resources.ApplyResources(this, "OH_$this");
        this.Name = "OperationPanel";
        this.ResumeLayout(false);
    }

    #endregion

    private Button btnAdd;
    private Button btnRemove;
    private Button btnClear;
    private Button btnRun;
}

}   //  End of namespace  WinFormsControl
