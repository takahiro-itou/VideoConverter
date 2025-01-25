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
**      An Implementation of CustomComponentResourceManager class.
**
**      @file       CustomComponentResourceManager.cs
**/

using System.ComponentModel;

namespace WinFormsControl
{

//========================================================================
//
//    CustomComponentResourceManager  class.
//

public class CustomComponentResourceManager
    : System.ComponentModel.ComponentResourceManager
{
    public CustomComponentResourceManager(System.Type t, string resourceName)
        : base(t)
    {
        this.BaseNameField = resourceName;
    }

}

}
