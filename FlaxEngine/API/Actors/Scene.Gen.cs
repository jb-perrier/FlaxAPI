////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2012-2017 Flax Engine. All rights reserved.
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
	/// <summary>
	/// Scene root actor object
	/// </summary>
	public sealed partial class Scene : Actor
	{
		/// <summary>
		/// Gets path to the scene file. It's valid only in Editor.
		/// </summary>
		[UnmanagedCall]
		public string Path
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetPath(unmanagedPtr); }
#endif
		}

		/// <summary>
		/// Gets filename of the scene file. It's valid only in Editor.
		/// </summary>
		[UnmanagedCall]
		public string Filename
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetFilename(unmanagedPtr); }
#endif
		}

		/// <summary>
		/// Gets path to the scene data folder. It's valid only in Editor.
		/// </summary>
		[UnmanagedCall]
		public string DataFolderPath
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetDataFolderPath(unmanagedPtr); }
#endif
		}

		/// <summary>
		/// Unloads given scene. Done in sync, in the end of the next engine tick.
		/// </summary>
#if UNIT_TEST_COMPILANT
		[Obsolete("Unit tests, don't support methods calls.")]
#endif
		[UnmanagedCall]
		public static void Unload() 
		{
#if UNIT_TEST_COMPILANT
			throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
			Internal_Unload();
#endif
		}

#region Internal Calls
#if !UNIT_TEST_COMPILANT
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string Internal_GetPath(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string Internal_GetFilename(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string Internal_GetDataFolderPath(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_Unload();
#endif
#endregion
	}
}

