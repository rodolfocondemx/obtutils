﻿/***************************************************************************
 *   Copyright (C) 2012 by Rodolfo Conde Martínez                          *
 *   rcm@gmx.co.uk                                                         *
 *                                                                         *
 *   This is property of Compumed, Corp.                                   *
 ***************************************************************************/



using System;
using System.Collections.Generic;

namespace OBTUtils
{
	/// <summary>
	/// Contains general information about the current application
	/// </summary>
	/// 
	/// <remarks>\author \rconde</remarks>
	public static class OBTApplicationInformation
	{
		/// <summary>
		/// App's short name
		/// </summary>
		public const string appName = "OBTUtils";
		
		/// <summary>
		/// App's long name
		/// </summary>
		public const string appLongName = "OBTUtils";
		
		/// <summary>
		/// App's description
		/// </summary>
		public const string appDescription = "Some common stuff useful for programs";
		
		/// <summary>
		/// App's global version
		/// </summary>
		public const string appVersion = "3.2.0";
		
		/// <summary>
		/// Group or person responsible for the
		/// app's development
		/// </summary>
		public const string appCompany = "ØβŢ";
		
		/// <summary>
		/// String containing the copyright of the app's authors
		/// </summary>
		public const string appAuthorCopyright = "Copyright 2010-2013 (C) by " +
			"Rodolfo Conde Martínez";
		
		/// <summary>
		/// String containing the path in the filesystem
		/// of the app's help file
		/// </summary>
		public const string appMainHelpFile = "OBTutils.chm";
	}
}