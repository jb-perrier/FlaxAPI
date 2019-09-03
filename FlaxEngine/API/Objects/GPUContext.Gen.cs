// Copyright (c) 2012-2019 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FlaxEngine.Rendering
{
    /// <summary>
    /// Allows to perform custom graphics commands using GPU device and rendering pipeline.
    /// </summary>
    public sealed partial class GPUContext : Object
    {
        /// <summary>
        /// Creates new <see cref="GPUContext"/> object.
        /// </summary>
        private GPUContext() : base()
        {
        }

        /// <summary>
        /// Clears texture surface with a color.
        /// </summary>
        /// <param name="view">The render target view to clear. Must be valid and created.</param>
        /// <param name="color">Clear color.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void Clear(RenderTargetView view, Color color)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_Clear(unmanagedPtr, view, ref color);
#endif
        }

        /// <summary>
        /// Clears depth buffer.
        /// </summary>
        /// <param name="depthBuffer">Depth buffer to clear.</param>
        /// <param name="depthValue">Clear depth value.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void ClearDepth(RenderTarget depthBuffer, float depthValue = 1.0f)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_ClearDepth(unmanagedPtr, Object.GetUnmanagedPtr(depthBuffer), depthValue);
#endif
        }

        /// <summary>
        /// Resolves the multisampled texture by performing a copy of the resource into a non-multisampled resource.
        /// </summary>
        /// <param name="sourceMultisampleTexture">The source multisample texture. Must be multisampled.</param>
        /// <param name="destTexture">The destination texture. Must be single-sampled.</param>
        /// <param name="sourceSubResource">The source sub-resource index.</param>
        /// <param name="destSubResource">The destination sub-resource index.</param>
        /// <param name="format">The format. Indicates how the multisampled resource will be resolved to a single-sampled resource.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void ResolveMultisample(RenderTarget sourceMultisampleTexture, RenderTarget destTexture, int sourceSubResource = 0, int destSubResource = 0, PixelFormat format = PixelFormat.Unknown)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_ResolveMultisample(unmanagedPtr, Object.GetUnmanagedPtr(sourceMultisampleTexture), Object.GetUnmanagedPtr(destTexture), sourceSubResource, destSubResource, format);
#endif
        }

        /// <summary>
        /// Draws render target to other render target. Copies contents with resizing and format conversion support. Uses linear texture sampling.
        /// </summary>
        /// <param name="dst">Target surface.</param>
        /// <param name="src">Source surface.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void Draw(RenderTarget dst, RenderTarget src)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_Draw1(unmanagedPtr, Object.GetUnmanagedPtr(dst), Object.GetUnmanagedPtr(src));
#endif
        }

        /// <summary>
        /// Draws texture to render target. Copies contents with resizing and format conversion support. Uses linear texture sampling.
        /// </summary>
        /// <param name="dst">Target surface.</param>
        /// <param name="src">Source texture.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void Draw(RenderTarget dst, Texture src)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_Draw2(unmanagedPtr, Object.GetUnmanagedPtr(dst), Object.GetUnmanagedPtr(src));
#endif
        }

        /// <summary>
        /// Draws postFx material to the render target.
        /// </summary>
        /// <param name="material">The material to render. It must be a post fx material.</param>
        /// <param name="output">The output texture. Must be valid and created.</param>
        /// <param name="input">The input texture. It's optional.</param>
        /// <param name="view">Rendering view description structure.</param>
        /// <param name="buffers">Frame rendering buffers. Can be used by the material to gather per pixel surface properties.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void DrawPostFxMaterial(MaterialBase material, RenderTarget output, RenderTarget input, RenderView view, RenderBuffers buffers = null)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawPostFxMaterial1(unmanagedPtr, Object.GetUnmanagedPtr(material), Object.GetUnmanagedPtr(output), Object.GetUnmanagedPtr(input), ref view, Object.GetUnmanagedPtr(buffers));
#endif
        }

        /// <summary>
        /// Draws postFx material to the render target view. Can be used to draw material to subarea of the texture.
        /// </summary>
        /// <param name="material">The material to render. It must be a post fx material.</param>
        /// <param name="view">The output render target view. Must be valid and created.</param>
        /// <param name="input">The input texture. It's optional.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void DrawPostFxMaterial(MaterialBase material, RenderTargetView view, RenderTarget input = null)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawPostFxMaterial2(unmanagedPtr, Object.GetUnmanagedPtr(material), view, Object.GetUnmanagedPtr(input));
#endif
        }

        /// <summary>
        /// Draws postFx material to the render target view using a custom viewport. Can be used to draw material to subarea of the texture.
        /// </summary>
        /// <param name="material">The material to render. It must be a post fx material.</param>
        /// <param name="view">The output render target view. Must be valid and created.</param>
        /// <param name="viewport">The custom rendering viewport to use.</param>
        /// <param name="input">The input texture. It's optional.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void DrawPostFxMaterial(MaterialBase material, RenderTargetView view, ref Viewport viewport, RenderTarget input = null)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DrawPostFxMaterial3(unmanagedPtr, Object.GetUnmanagedPtr(material), view, ref viewport, Object.GetUnmanagedPtr(input));
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_Clear(IntPtr obj, RenderTargetView view, ref Color color);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_ClearDepth(IntPtr obj, IntPtr depthBuffer, float depthValue);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_ResolveMultisample(IntPtr obj, IntPtr sourceMultisampleTexture, IntPtr destTexture, int sourceSubResource, int destSubResource, PixelFormat format);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_Draw1(IntPtr obj, IntPtr dst, IntPtr src);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_Draw2(IntPtr obj, IntPtr dst, IntPtr src);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawPostFxMaterial1(IntPtr obj, IntPtr material, IntPtr output, IntPtr input, ref RenderView view, IntPtr buffers);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawPostFxMaterial2(IntPtr obj, IntPtr material, RenderTargetView view, IntPtr input);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DrawPostFxMaterial3(IntPtr obj, IntPtr material, RenderTargetView view, ref Viewport viewport, IntPtr input);
#endif

        #endregion
    }
}
