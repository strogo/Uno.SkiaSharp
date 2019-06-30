using System;
using System.Runtime.InteropServices;

using nullptr_t = System.IntPtr;
using size_t = System.IntPtr;
using voidptr_t = System.IntPtr;

using gr_backendrendertarget_t = System.IntPtr;
using gr_backendtexture_t = System.IntPtr;
using gr_context_t = System.IntPtr;
using gr_glinterface_t = System.IntPtr;

using sk_3dview_t = System.IntPtr;
using sk_bitmap_t = System.IntPtr;
using sk_canvas_t = System.IntPtr;
using sk_codec_t = System.IntPtr;
using sk_color_t = System.UInt32;
using sk_colorfilter_t = System.IntPtr;
using sk_colorspace_t = System.IntPtr;
using sk_colortable_t = System.IntPtr;
using sk_data_t = System.IntPtr;
using sk_document_t = System.IntPtr;
using sk_drawable_t = System.IntPtr;
using sk_font_table_tag_t = System.UInt32;
using sk_fontmgr_t = System.IntPtr;
using sk_fontstyle_t = System.IntPtr;
using sk_fontstyleset_t = System.IntPtr;
using sk_image_t = System.IntPtr;
using sk_imagefilter_croprect_t = System.IntPtr;
using sk_imagefilter_t = System.IntPtr;
using sk_manageddrawable_t = System.IntPtr;
using sk_maskfilter_t = System.IntPtr;
using sk_matrix44_t = System.IntPtr;
using sk_nodraw_canvas_t = System.IntPtr;
using sk_nway_canvas_t = System.IntPtr;
using sk_opbuilder_t = System.IntPtr;
using sk_overdraw_canvas_t = System.IntPtr;
using sk_paint_t = System.IntPtr;
using sk_path_effect_t = System.IntPtr;
using sk_path_iterator_t = System.IntPtr;
using sk_path_t = System.IntPtr;
using sk_pathmeasure_t = System.IntPtr;
using sk_picture_recorder_t = System.IntPtr;
using sk_picture_t = System.IntPtr;
using sk_pixmap_t = System.IntPtr;
using sk_pmcolor_t = System.UInt32;
using sk_region_t = System.IntPtr;
using sk_rrect_t = System.IntPtr;
using sk_shader_t = System.IntPtr;
using sk_stream_assetstream_t = System.IntPtr;
using sk_stream_filestream_t = System.IntPtr;
using sk_stream_managedstream_t = System.IntPtr;
using sk_stream_memorystream_t = System.IntPtr;
using sk_stream_t = System.IntPtr;
using sk_string_t = System.IntPtr;
using sk_surface_t = System.IntPtr;
using sk_surfaceprops_t = System.IntPtr;
using sk_textblob_builder_t = System.IntPtr;
using sk_textblob_t = System.IntPtr;
using sk_typeface_t = System.IntPtr;
using sk_vertices_t = System.IntPtr;
using sk_wstream_dynamicmemorystream_t = System.IntPtr;
using sk_wstream_filestream_t = System.IntPtr;
using sk_wstream_managedstream_t = System.IntPtr;
using sk_wstream_t = System.IntPtr;
using sk_xmlstreamwriter_t = System.IntPtr;
using sk_xmlwriter_t = System.IntPtr;

namespace SkiaSharp
{
#pragma warning disable IDE1006 // Naming Styles

	internal static unsafe class SkiaApiDelegates
	{
		// color space

		public delegate void sk_colorspace_unref (sk_colorspace_t cColorSpace);

		public delegate bool sk_colorspace_gamma_close_to_srgb (sk_colorspace_t cColorSpace);

		public delegate bool sk_colorspace_gamma_is_linear (sk_colorspace_t cColorSpace);

		public delegate bool sk_colorspace_is_srgb (sk_colorspace_t cColorSpace);

		public delegate SKColorSpaceType sk_colorspace_gamma_get_type (sk_colorspace_t cColorSpace);

		public delegate SKNamedGamma sk_colorspace_gamma_get_gamma_named (sk_colorspace_t cColorSpace);


		public delegate bool sk_colorspace_equals (sk_colorspace_t src, sk_colorspace_t dst);

		public delegate sk_colorspace_t sk_colorspace_new_srgb ();

		public delegate sk_colorspace_t sk_colorspace_new_srgb_linear ();

		public delegate sk_colorspace_t sk_colorspace_new_icc (voidptr_t input, size_t len);

		public delegate sk_colorspace_t sk_colorspace_new_icc_2 (byte[] input, size_t len);

		public delegate sk_colorspace_t sk_colorspace_new_rgb_with_gamma (SKColorSpaceRenderTargetGamma gamma, sk_matrix44_t toXYZD50);

		public delegate sk_colorspace_t sk_colorspace_new_rgb_with_gamma_and_gamut (SKColorSpaceRenderTargetGamma gamma, SKColorSpaceGamut gamut);

		public delegate sk_colorspace_t sk_colorspace_new_rgb_with_coeffs (ref SKColorSpaceTransferFn coeffs, sk_matrix44_t toXYZD50);

		public delegate sk_colorspace_t sk_colorspace_new_rgb_with_coeffs_and_gamut (ref SKColorSpaceTransferFn coeffs, SKColorSpaceGamut gamut);

		public delegate sk_colorspace_t sk_colorspace_new_rgb_with_gamma_named (SKNamedGamma gamma, sk_matrix44_t toXYZD50);

		public delegate sk_colorspace_t sk_colorspace_new_rgb_with_gamma_named_and_gamut (SKNamedGamma gamma, SKColorSpaceGamut gamut);


		public delegate bool sk_colorspace_to_xyzd50 (sk_colorspace_t cColorSpace, sk_matrix44_t toXYZD50);

		public delegate sk_matrix44_t sk_colorspace_as_to_xyzd50 (sk_colorspace_t cColorSpace);

		public delegate sk_matrix44_t sk_colorspace_as_from_xyzd50 (sk_colorspace_t cColorSpace);


		public delegate bool sk_colorspace_is_numerical_transfer_fn (sk_colorspace_t cColorSpace, out SKColorSpaceTransferFn fn);


		public delegate bool sk_colorspaceprimaries_to_xyzd50 (ref SKColorSpacePrimaries primaries, sk_matrix44_t toXYZD50);

		public delegate void sk_colorspace_transfer_fn_invert (ref SKColorSpaceTransferFn transfer, out SKColorSpaceTransferFn inverted);

		public delegate float sk_colorspace_transfer_fn_transform (ref SKColorSpaceTransferFn transfer, float x);

		// color type

		public delegate SKColorType sk_colortype_get_default_8888 ();

		// surface

		public delegate sk_surface_t sk_surface_new_null (int width, int height);

		public delegate void sk_surface_unref (sk_surface_t t);

		public delegate sk_surface_t sk_surface_new_raster (ref SKImageInfoNative info, size_t rowBytes, sk_surfaceprops_t props);

		public delegate sk_surface_t sk_surface_new_raster_direct (ref SKImageInfoNative info, voidptr_t pixels, size_t rowBytes, SKSurfaceReleaseDelegateProxyDelegate releaseProc, voidptr_t context, sk_surfaceprops_t props);

		public delegate sk_canvas_t sk_surface_get_canvas (sk_surface_t t);

		public delegate sk_image_t sk_surface_new_image_snapshot (sk_surface_t t);

		public delegate sk_surface_t sk_surface_new_backend_render_target (gr_context_t context, gr_backendrendertarget_t target, GRSurfaceOrigin origin, SKColorType colorType, sk_colorspace_t colorspace, sk_surfaceprops_t props);

		public delegate sk_surface_t sk_surface_new_backend_texture (gr_context_t context, gr_backendtexture_t texture, GRSurfaceOrigin origin, int samples, SKColorType colorType, sk_colorspace_t colorspace, sk_surfaceprops_t props);

		public delegate sk_surface_t sk_surface_new_backend_texture_as_render_target (gr_context_t context, gr_backendtexture_t texture, GRSurfaceOrigin origin, int samples, SKColorType colorType, sk_colorspace_t colorspace, sk_surfaceprops_t props);

		public delegate sk_surface_t sk_surface_new_render_target (gr_context_t context, [MarshalAs (UnmanagedType.I1)] bool budgeted, ref SKImageInfoNative info, int sampleCount, GRSurfaceOrigin origin, sk_surfaceprops_t props, [MarshalAs (UnmanagedType.I1)] bool shouldCreateWithMips);

		public delegate void sk_surface_draw (sk_surface_t surface, sk_canvas_t canvas, float x, float y, sk_paint_t paint);


		public delegate bool sk_surface_peek_pixels (sk_surface_t surface, sk_pixmap_t pixmap);


		public delegate bool sk_surface_read_pixels (sk_surface_t surface, ref SKImageInfoNative dstInfo, voidptr_t dstPixels, size_t dstRowBytes, int srcX, int srcY);

		public delegate sk_surfaceprops_t sk_surface_get_props (sk_surface_t surface);

		// surface props

		public delegate sk_surfaceprops_t sk_surfaceprops_new (UInt32 flags, SKPixelGeometry geometry);

		public delegate void sk_surfaceprops_delete (sk_surfaceprops_t props);

		public delegate UInt32 sk_surfaceprops_get_flags (sk_surfaceprops_t props);

		public delegate SKPixelGeometry sk_surfaceprops_get_pixel_geometry (sk_surfaceprops_t props);

		// canvas

		public delegate int sk_canvas_save (sk_canvas_t t);

		public delegate int sk_canvas_save_layer (sk_canvas_t t, ref SKRect rect, sk_paint_t paint);

		public delegate int sk_canvas_save_layer_2 (sk_canvas_t t, nullptr_t rectZero, sk_paint_t paint);

		public delegate void sk_canvas_restore (sk_canvas_t t);

		public delegate int sk_canvas_get_save_count (sk_canvas_t t);

		public delegate void sk_canvas_restore_to_count (sk_canvas_t t, int saveCount);

		public delegate void sk_canvas_translate (sk_canvas_t t, float dx, float dy);

		public delegate void sk_canvas_scale (sk_canvas_t t, float sx, float sy);

		public delegate void sk_canvas_rotate_degrees (sk_canvas_t t, float degrees);

		public delegate void sk_canvas_rotate_radians (sk_canvas_t t, float radians);

		public delegate void sk_canvas_skew (sk_canvas_t t, float sx, float sy);

		public delegate void sk_canvas_concat (sk_canvas_t t, ref SKMatrix m);


		public delegate bool sk_canvas_quick_reject (sk_canvas_t t, ref SKRect rect);

		public delegate void sk_canvas_draw_paint (sk_canvas_t t, sk_paint_t p);

		public delegate void sk_canvas_draw_region (sk_canvas_t t, sk_region_t region, sk_paint_t paint);

		public delegate void sk_canvas_draw_rect (sk_canvas_t t, ref SKRect rect, sk_paint_t paint);

		public delegate void sk_canvas_draw_rrect (sk_canvas_t t, sk_rrect_t rect, sk_paint_t paint);

		public delegate void sk_canvas_draw_round_rect (sk_canvas_t t, ref SKRect rect, float rx, float ry, sk_paint_t paint);

		public delegate void sk_canvas_draw_oval (sk_canvas_t t, ref SKRect rect, sk_paint_t paint);

		public delegate void sk_canvas_draw_circle (sk_canvas_t t, float cx, float cy, float radius, sk_paint_t paint);

		public delegate void sk_canvas_draw_path (sk_canvas_t t, sk_path_t path, sk_paint_t paint);

		public delegate void sk_canvas_draw_image (sk_canvas_t t, sk_image_t image, float x, float y, sk_paint_t paint);

		public delegate void sk_canvas_draw_image_rect (sk_canvas_t t, sk_image_t image, ref SKRect src, ref SKRect dest, sk_paint_t paint);

		public delegate void sk_canvas_draw_image_rect_2 (sk_canvas_t t, sk_image_t image, nullptr_t srcZero, ref SKRect dest, sk_paint_t paint);

		public delegate void sk_canvas_draw_picture (sk_canvas_t t, sk_picture_t pict, ref SKMatrix mat, sk_paint_t paint);

		public delegate void sk_canvas_draw_picture_2 (sk_canvas_t t, sk_picture_t pict, nullptr_t matZero, sk_paint_t paint);

		public delegate void sk_canvas_draw_drawable (sk_canvas_t t, sk_manageddrawable_t drawable, ref SKMatrix mat);

		public delegate void sk_canvas_draw_color (sk_canvas_t t, SKColor color, SKBlendMode mode);

		public delegate void sk_canvas_draw_points (sk_canvas_t t, SKPointMode mode, size_t count, [In] SKPoint[] points, sk_paint_t paint);

		public delegate void sk_canvas_draw_point (sk_canvas_t t, float x, float y, sk_paint_t paint);

		public delegate void sk_canvas_draw_line (sk_canvas_t t, float x0, float y0, float x1, float y1, sk_paint_t paint);

		public delegate void sk_canvas_draw_text (sk_canvas_t t, byte[] text, int len, float x, float y, sk_paint_t paint);

		public delegate void sk_canvas_draw_pos_text (sk_canvas_t t, byte[] text, int len, [In] SKPoint[] points, sk_paint_t paint);

		public delegate void sk_canvas_draw_text_on_path (sk_canvas_t t, byte[] text, int len, sk_path_t path, float hOffset, float vOffset, sk_paint_t paint);

		public delegate void sk_canvas_draw_text_2 (sk_canvas_t t, voidptr_t text, int len, float x, float y, sk_paint_t paint);

		public delegate void sk_canvas_draw_pos_text_2 (sk_canvas_t t, voidptr_t text, int len, [In] SKPoint[] points, sk_paint_t paint);

		public delegate void sk_canvas_draw_text_on_path_2 (sk_canvas_t t, voidptr_t text, int len, sk_path_t path, float hOffset, float vOffset, sk_paint_t paint);

		public delegate void sk_canvas_draw_text_blob (sk_canvas_t canvas, sk_textblob_t text, float x, float y, sk_paint_t paint);

		public delegate void sk_canvas_draw_bitmap (sk_canvas_t t, sk_bitmap_t bitmap, float x, float y, sk_paint_t paint);

		public delegate void sk_canvas_draw_bitmap_rect (sk_canvas_t t, sk_bitmap_t bitmap, ref SKRect src, ref SKRect dest, sk_paint_t paint);

		public delegate void sk_canvas_draw_bitmap_rect_2 (sk_canvas_t t, sk_bitmap_t bitmap, nullptr_t srcZero, ref SKRect dest, sk_paint_t paint);

		public delegate void sk_canvas_reset_matrix (sk_canvas_t canvas);

		public delegate void sk_canvas_set_matrix (sk_canvas_t canvas, ref SKMatrix matrix);

		public delegate void sk_canvas_get_total_matrix (sk_canvas_t canvas, ref SKMatrix matrix);

		public delegate void sk_canvas_draw_annotation (sk_canvas_t t, ref SKRect rect, byte[] key, sk_data_t value);

		public delegate void sk_canvas_draw_url_annotation (sk_canvas_t t, ref SKRect rect, sk_data_t value);

		public delegate void sk_canvas_draw_named_destination_annotation (sk_canvas_t t, ref SKPoint point, sk_data_t value);

		public delegate void sk_canvas_draw_link_destination_annotation (sk_canvas_t t, ref SKRect rect, sk_data_t value);

		public delegate void sk_canvas_clip_rrect_with_operation (sk_canvas_t t, sk_rrect_t crect, SKClipOperation op, [MarshalAs (UnmanagedType.I1)] bool doAA);

		public delegate void sk_canvas_clip_rect_with_operation (sk_canvas_t t, ref SKRect crect, SKClipOperation op, [MarshalAs (UnmanagedType.I1)] bool doAA);

		public delegate void sk_canvas_clip_path_with_operation (sk_canvas_t t, sk_path_t cpath, SKClipOperation op, [MarshalAs (UnmanagedType.I1)] bool doAA);

		public delegate void sk_canvas_clip_region (sk_canvas_t t, sk_region_t region, SKClipOperation op);


		public delegate bool sk_canvas_get_device_clip_bounds (sk_canvas_t t, out SKRectI cbounds);


		public delegate bool sk_canvas_get_local_clip_bounds (sk_canvas_t t, out SKRect cbounds);

		public delegate sk_canvas_t sk_canvas_new_from_bitmap (sk_bitmap_t bitmap);

		public delegate void sk_canvas_flush (sk_canvas_t canvas);

		public delegate void sk_canvas_draw_bitmap_lattice (sk_canvas_t t, sk_bitmap_t bitmap, ref SKLatticeInternal lattice, ref SKRect dst, sk_paint_t paint);

		public delegate void sk_canvas_draw_image_lattice (sk_canvas_t t, sk_image_t image, ref SKLatticeInternal lattice, ref SKRect dst, sk_paint_t paint);

		public delegate void sk_canvas_draw_bitmap_nine (sk_canvas_t t, sk_bitmap_t bitmap, ref SKRectI center, ref SKRect dst, sk_paint_t paint);

		public delegate void sk_canvas_draw_image_nine (sk_canvas_t t, sk_image_t image, ref SKRectI center, ref SKRect dst, sk_paint_t paint);

		public delegate void sk_canvas_destroy (sk_canvas_t canvas);

		public delegate void sk_canvas_draw_vertices (sk_canvas_t canvas, sk_vertices_t vertices, SKBlendMode mode, sk_paint_t paint);

		// no draw canvas

		public delegate sk_nodraw_canvas_t sk_nodraw_canvas_new (int width, int height);

		public delegate void sk_nodraw_canvas_destroy (sk_nodraw_canvas_t t);

		// n-way canvas

		public delegate sk_nway_canvas_t sk_nway_canvas_new (int width, int height);

		public delegate void sk_nway_canvas_destroy (sk_nway_canvas_t t);

		public delegate void sk_nway_canvas_add_canvas (sk_nway_canvas_t t, sk_canvas_t canvas);

		public delegate void sk_nway_canvas_remove_canvas (sk_nway_canvas_t t, sk_canvas_t canvas);

		public delegate void sk_nway_canvas_remove_all (sk_nway_canvas_t t);

		// overdraw canvas

		public delegate sk_overdraw_canvas_t sk_overdraw_canvas_new (sk_canvas_t canvas);

		public delegate void sk_overdraw_canvas_destroy (sk_overdraw_canvas_t canvas);

		// paint

		public delegate sk_paint_t sk_paint_new ();

		public delegate void sk_paint_delete (sk_paint_t t);

		public delegate void sk_paint_reset (sk_paint_t t);


		public delegate bool sk_paint_is_antialias (sk_paint_t t);

		public delegate void sk_paint_set_antialias (sk_paint_t t, [MarshalAs (UnmanagedType.I1)] bool v);


		public delegate bool sk_paint_is_dither (sk_paint_t t);

		public delegate void sk_paint_set_dither (sk_paint_t t, [MarshalAs (UnmanagedType.I1)] bool v);


		public delegate bool sk_paint_is_verticaltext (sk_paint_t t);

		public delegate void sk_paint_set_verticaltext (sk_paint_t t, [MarshalAs (UnmanagedType.I1)] bool v);

		public delegate sk_color_t sk_paint_get_color (sk_paint_t t);

		public delegate void sk_paint_set_color (sk_paint_t t, SKColor color);

		public delegate SKPaintStyle sk_paint_get_style (sk_paint_t t);

		public delegate void sk_paint_set_style (sk_paint_t t, SKPaintStyle style);

		public delegate float sk_paint_get_stroke_width (sk_paint_t paint);

		public delegate void sk_paint_set_stroke_width (sk_paint_t t, float width);

		public delegate float sk_paint_get_stroke_miter (sk_paint_t t);

		public delegate void sk_paint_set_stroke_miter (sk_paint_t t, float miter);

		public delegate SKStrokeCap sk_paint_get_stroke_cap (sk_paint_t t);

		public delegate void sk_paint_set_stroke_cap (sk_paint_t t, SKStrokeCap cap);

		public delegate SKStrokeJoin sk_paint_get_stroke_join (sk_paint_t t);

		public delegate void sk_paint_set_stroke_join (sk_paint_t t, SKStrokeJoin join);

		public delegate void sk_paint_set_shader (sk_paint_t t, sk_shader_t shader);

		public delegate sk_shader_t sk_paint_get_shader (sk_paint_t t);

		public delegate void sk_paint_set_maskfilter (sk_paint_t t, sk_maskfilter_t filter);

		public delegate sk_maskfilter_t sk_paint_get_maskfilter (sk_paint_t t);

		public delegate void sk_paint_set_colorfilter (sk_paint_t t, sk_colorfilter_t filter);

		public delegate sk_colorfilter_t sk_paint_get_colorfilter (sk_paint_t t);

		public delegate void sk_paint_set_imagefilter (sk_paint_t t, sk_imagefilter_t filter);

		public delegate sk_imagefilter_t sk_paint_get_imagefilter (sk_paint_t t);

		public delegate void sk_paint_set_blendmode (sk_paint_t t, SKBlendMode mode);

		public delegate SKBlendMode sk_paint_get_blendmode (sk_paint_t t);

		public delegate void sk_paint_set_filter_quality (sk_paint_t t, SKFilterQuality filterQuality);

		public delegate SKFilterQuality sk_paint_get_filter_quality (sk_paint_t t);

		public delegate sk_typeface_t sk_paint_get_typeface (sk_paint_t t);

		public delegate void sk_paint_set_typeface (sk_paint_t t, sk_typeface_t typeface);

		public delegate float sk_paint_get_textsize (sk_paint_t t);

		public delegate void sk_paint_set_textsize (sk_paint_t t, float size);

		public delegate SKTextAlign sk_paint_get_text_align (sk_paint_t t);

		public delegate void sk_paint_set_text_align (sk_paint_t t, SKTextAlign align);

		public delegate SKTextEncoding sk_paint_get_text_encoding (sk_paint_t t);

		public delegate void sk_paint_set_text_encoding (sk_paint_t t, SKTextEncoding encoding);

		public delegate float sk_paint_get_text_scale_x (sk_paint_t t);

		public delegate void sk_paint_set_text_scale_x (sk_paint_t t, float scale);

		public delegate float sk_paint_get_text_skew_x (sk_paint_t t);

		public delegate void sk_paint_set_text_skew_x (sk_paint_t t, float skew);

		public delegate float sk_paint_measure_text (sk_paint_t t, voidptr_t text, size_t length, ref SKRect bounds);

		public delegate float sk_paint_measure_text_2 (sk_paint_t t, voidptr_t text, size_t length, nullptr_t boundsZero);

		public delegate size_t sk_paint_break_text (sk_paint_t t, voidptr_t text, size_t length, float maxWidth, out float measuredWidth);

		public delegate sk_path_t sk_paint_get_text_path (sk_paint_t t, voidptr_t text, size_t length, float x, float y);

		public delegate sk_path_t sk_paint_get_pos_text_path (sk_paint_t t, voidptr_t text, size_t length, [In] SKPoint[] points);

		public delegate float sk_paint_get_fontmetrics (sk_paint_t t, out SKFontMetrics fontMetrics, float scale);

		public delegate float sk_paint_get_fontmetrics_2 (sk_paint_t t, nullptr_t fontMetricsZero, float scale);

		public delegate sk_path_effect_t sk_paint_get_path_effect (sk_paint_t cpaint);

		public delegate void sk_paint_set_path_effect (sk_paint_t cpaint, sk_path_effect_t effect);


		public delegate bool sk_paint_is_linear_text (sk_paint_t cpaint);

		public delegate void sk_paint_set_linear_text (sk_paint_t cpaint, [MarshalAs (UnmanagedType.I1)] bool linearText);


		public delegate bool sk_paint_is_subpixel_text (sk_paint_t cpaint);

		public delegate void sk_paint_set_subpixel_text (sk_paint_t cpaint, [MarshalAs (UnmanagedType.I1)] bool subpixelText);


		public delegate bool sk_paint_is_lcd_render_text (sk_paint_t cpaint);

		public delegate void sk_paint_set_lcd_render_text (sk_paint_t cpaint, [MarshalAs (UnmanagedType.I1)] bool lcdText);


		public delegate bool sk_paint_is_embedded_bitmap_text (sk_paint_t cpaint);

		public delegate void sk_paint_set_embedded_bitmap_text (sk_paint_t cpaint, [MarshalAs (UnmanagedType.I1)] bool useEmbeddedBitmapText);


		public delegate bool sk_paint_is_autohinted (sk_paint_t cpaint);

		public delegate void sk_paint_set_autohinted (sk_paint_t cpaint, [MarshalAs (UnmanagedType.I1)] bool useAutohinter);

		public delegate SKPaintHinting sk_paint_get_hinting (sk_paint_t cpaint);

		public delegate void sk_paint_set_hinting (sk_paint_t cpaint, SKPaintHinting hintingLevel);


		public delegate bool sk_paint_is_fake_bold_text (sk_paint_t cpaint);

		public delegate void sk_paint_set_fake_bold_text (sk_paint_t cpaint, [MarshalAs (UnmanagedType.I1)] bool fakeBoldText);


		public delegate bool sk_paint_is_dev_kern_text (sk_paint_t cpaint);

		public delegate void sk_paint_set_dev_kern_text (sk_paint_t cpaint, [MarshalAs (UnmanagedType.I1)] bool devKernText);


		public delegate bool sk_paint_get_fill_path (sk_paint_t paint, sk_path_t src, sk_path_t dst, ref SKRect cullRect, float resScale);


		public delegate bool sk_paint_get_fill_path_2 (sk_paint_t paint, sk_path_t src, sk_path_t dst, nullptr_t cullRectZero, float resScale);

		public delegate sk_paint_t sk_paint_clone (sk_paint_t cpaint);

		public delegate int sk_paint_text_to_glyphs (sk_paint_t cpaint, voidptr_t text, size_t byteLength, UInt16* glyphs);


		public delegate bool sk_paint_contains_text (sk_paint_t cpaint, voidptr_t text, size_t byteLength);

		public delegate int sk_paint_count_text (sk_paint_t cpaint, voidptr_t text, size_t byteLength);

		public delegate int sk_paint_get_text_widths (sk_paint_t cpaint, voidptr_t text, size_t byteLength, float* widths, SKRect* bounds);

		public delegate int sk_paint_get_text_intercepts (sk_paint_t cpaint, voidptr_t text, size_t byteLength, float x, float y, float[] bounds, float* intervals);

		public delegate int sk_paint_get_pos_text_intercepts (sk_paint_t cpaint, voidptr_t text, size_t byteLength, SKPoint[] pos, float[] bounds, float* intervals);

		public delegate int sk_paint_get_pos_text_h_intercepts (sk_paint_t cpaint, voidptr_t text, size_t byteLength, float[] xpos, float y, float[] bounds, float* intervals);

		public delegate int sk_paint_get_pos_text_blob_intercepts (sk_paint_t cpaint, sk_textblob_t blob, float[] bounds, float* intervals);


		// image

		public delegate void sk_image_ref (sk_image_t image);

		public delegate void sk_image_unref (sk_image_t image);

		public delegate sk_image_t sk_image_new_raster_copy (ref SKImageInfoNative info, voidptr_t pixels, size_t rowBytes);

		public delegate sk_image_t sk_image_new_raster_copy_with_pixmap (sk_pixmap_t pixmap);

		public delegate sk_image_t sk_image_new_raster_data (ref SKImageInfoNative info, sk_data_t pixels, size_t rowBytes);

		public delegate sk_image_t sk_image_new_raster (sk_pixmap_t pixmap, SKImageRasterReleaseDelegateProxyDelegate releaseProc, voidptr_t context);

		public delegate sk_image_t sk_image_new_from_bitmap (sk_bitmap_t cbitmap);

		public delegate sk_image_t sk_image_new_from_encoded (sk_data_t encoded, ref SKRectI subset);

		public delegate sk_image_t sk_image_new_from_encoded_2 (sk_data_t encoded, nullptr_t subsetZero);

		public delegate sk_image_t sk_image_new_from_texture (gr_context_t context, gr_backendtexture_t texture, GRSurfaceOrigin origin, SKColorType colorType, SKAlphaType alpha, sk_colorspace_t colorSpace, SKImageTextureReleaseDelegateProxyDelegate releaseProc, voidptr_t releaseContext);

		public delegate sk_image_t sk_image_new_from_adopted_texture (gr_context_t context, gr_backendtexture_t texture, GRSurfaceOrigin origin, SKColorType colorType, SKAlphaType alpha, sk_colorspace_t colorSpace);

		public delegate sk_image_t sk_image_new_from_picture (sk_picture_t picture, ref SKSizeI dimensions, ref SKMatrix matrix, sk_paint_t paint);

		public delegate sk_image_t sk_image_new_from_picture_2 (sk_picture_t picture, ref SKSizeI dimensions, nullptr_t matrixZero, sk_paint_t paint);

		public delegate int sk_image_get_width (sk_image_t image);

		public delegate int sk_image_get_height (sk_image_t image);

		public delegate uint sk_image_get_unique_id (sk_image_t image);

		public delegate SKAlphaType sk_image_get_alpha_type (sk_image_t image);

		public delegate SKColorType sk_image_get_color_type (sk_image_t image);

		public delegate sk_colorspace_t sk_image_get_colorspace (sk_image_t image);


		public delegate bool sk_image_is_alpha_only (sk_image_t image);

		public delegate sk_shader_t sk_image_make_shader (sk_image_t image, SKShaderTileMode tileX, SKShaderTileMode tileY, ref SKMatrix localMatrix);

		public delegate sk_shader_t sk_image_make_shader_2 (sk_image_t image, SKShaderTileMode tileX, SKShaderTileMode tileY, nullptr_t localMatrixZero);


		public delegate bool sk_image_peek_pixels (sk_image_t image, sk_pixmap_t pixmap);


		public delegate bool sk_image_is_texture_backed (sk_image_t image);


		public delegate bool sk_image_is_lazy_generated (sk_image_t image);


		public delegate bool sk_image_read_pixels (sk_image_t image, ref SKImageInfoNative dstInfo, voidptr_t dstPixels, size_t dstRowBytes, int srcX, int srcY, SKImageCachingHint cachingHint);


		public delegate bool sk_image_read_pixels_into_pixmap (sk_image_t image, sk_pixmap_t dst, int srcX, int srcY, SKImageCachingHint cachingHint);


		public delegate bool sk_image_scale_pixels (sk_image_t image, sk_pixmap_t dst, SKFilterQuality quality, SKImageCachingHint cachingHint);

		public delegate sk_data_t sk_image_ref_encoded (sk_image_t image);

		public delegate sk_data_t sk_image_encode (sk_image_t image);

		public delegate sk_data_t sk_image_encode_specific (sk_image_t image, SKEncodedImageFormat encoder, int quality);

		public delegate sk_image_t sk_image_make_subset (sk_image_t image, ref SKRectI subset);

		public delegate sk_image_t sk_image_make_non_texture_image (sk_image_t image);

		public delegate sk_image_t sk_image_make_with_filter (sk_image_t image, sk_imagefilter_t filter, ref SKRectI subset, ref SKRectI clipbounds, out SKRectI outSubset, out SKPoint outOffset);

		// path


		public delegate bool sk_path_contains (sk_path_t cpath, float x, float y);


		public delegate bool sk_path_get_last_point (sk_path_t cpath, out SKPoint point);

		public delegate sk_path_t sk_path_new ();

		public delegate void sk_path_delete (sk_path_t t);

		public delegate void sk_path_move_to (sk_path_t t, float x, float y);

		public delegate void sk_path_rmove_to (sk_path_t t, float dx, float dy);

		public delegate void sk_path_line_to (sk_path_t t, float x, float y);

		public delegate void sk_path_rline_to (sk_path_t t, float dx, float dy);

		public delegate void sk_path_quad_to (sk_path_t t, float x0, float y0, float x1, float y1);

		public delegate void sk_path_rquad_to (sk_path_t t, float dx0, float dy0, float dx1, float dy1);

		public delegate void sk_path_conic_to (sk_path_t t, float x0, float y0, float x1, float y1, float w);

		public delegate void sk_path_rconic_to (sk_path_t t, float dx0, float dy0, float dx1, float dy1, float w);

		public delegate void sk_path_cubic_to (sk_path_t t, float x0, float y0, float x1, float y1, float x2, float y2);

		public delegate void sk_path_rcubic_to (sk_path_t t, float dx0, float dy0, float dx1, float dy1, float dx2, float dy2);

		public delegate void sk_path_close (sk_path_t t);

		public delegate void sk_path_rewind (sk_path_t t);

		public delegate void sk_path_reset (sk_path_t t);

		public delegate void sk_path_add_rect (sk_path_t t, ref SKRect rect, SKPathDirection direction);

		public delegate void sk_path_add_rect_start (sk_path_t t, ref SKRect rect, SKPathDirection direction, uint startIndex);

		public delegate void sk_path_add_rrect (sk_path_t t, sk_rrect_t rect, SKPathDirection direction);

		public delegate void sk_path_add_rrect_start (sk_path_t t, sk_rrect_t rect, SKPathDirection direction, uint startIndex);

		public delegate void sk_path_add_oval (sk_path_t t, ref SKRect rect, SKPathDirection direction);

		public delegate void sk_path_add_arc (sk_path_t t, ref SKRect rect, float startAngle, float sweepAngle);

		public delegate void sk_path_add_path_offset (sk_path_t t, sk_path_t other, float dx, float dy, SKPathAddMode mode);

		public delegate void sk_path_add_path_matrix (sk_path_t t, sk_path_t other, ref SKMatrix matrix, SKPathAddMode mode);

		public delegate void sk_path_add_path (sk_path_t t, sk_path_t other, SKPathAddMode mode);

		public delegate void sk_path_add_path_reverse (sk_path_t t, sk_path_t other);

		public delegate void sk_path_get_bounds (sk_path_t t, out SKRect rect);

		public delegate void sk_path_compute_tight_bounds (sk_path_t t, out SKRect rect);

		public delegate SKPathFillType sk_path_get_filltype (sk_path_t t);

		public delegate void sk_path_set_filltype (sk_path_t t, SKPathFillType filltype);

		public delegate sk_path_t sk_path_clone (sk_path_t t);

		public delegate sk_path_t sk_path_transform (sk_path_t t, ref SKMatrix matrix);

		public delegate void sk_path_arc_to (sk_path_t t, float rx, float ry, float xAxisRotate, SKPathArcSize largeArc, SKPathDirection sweep, float x, float y);

		public delegate void sk_path_rarc_to (sk_path_t t, float rx, float ry, float xAxisRotate, SKPathArcSize largeArc, SKPathDirection sweep, float x, float y);

		public delegate void sk_path_arc_to_with_oval (sk_path_t t, ref SKRect oval, float startAngle, float sweepAngle, [MarshalAs (UnmanagedType.I1)] bool forceMoveTo);

		public delegate void sk_path_arc_to_with_points (sk_path_t t, float x1, float y1, float x2, float y2, float radius);

		public delegate void sk_path_add_rounded_rect (sk_path_t t, ref SKRect rect, float rx, float ry, SKPathDirection dir);

		public delegate void sk_path_add_circle (sk_path_t t, float x, float y, float radius, SKPathDirection dir);

		public delegate int sk_path_count_verbs (sk_path_t path);

		public delegate int sk_path_count_points (sk_path_t path);

		public delegate void sk_path_get_point (sk_path_t path, int index, out SKPoint point);

		public delegate int sk_path_get_points (sk_path_t path, [Out] SKPoint[] points, int max);

		public delegate SKPathConvexity sk_path_get_convexity (sk_path_t cpath);

		public delegate void sk_path_set_convexity (sk_path_t cpath, SKPathConvexity convexity);


		public delegate bool sk_path_parse_svg_string (sk_path_t cpath, [MarshalAs (UnmanagedType.LPStr)] string str);

		public delegate void sk_path_to_svg_string (sk_path_t cpath, sk_string_t str);

		public delegate int sk_path_convert_conic_to_quads (ref SKPoint p0, ref SKPoint p1, ref SKPoint p2, float w, [Out] SKPoint[] pts, int pow2);

		public delegate void sk_path_add_poly (sk_path_t cpath, [In] SKPoint[] points, int count, [MarshalAs (UnmanagedType.I1)] bool close);

		public delegate SKPathSegmentMask sk_path_get_segment_masks (sk_path_t t);


		public delegate bool sk_path_is_oval (sk_path_t cpath, out SKRect bounds);


		public delegate bool sk_path_is_rrect (sk_path_t cpath, sk_rrect_t bounds);


		public delegate bool sk_path_is_line (sk_path_t cpath, [Out] SKPoint[] line);


		public delegate bool sk_path_is_rect (sk_path_t cpath, out SKRect rect, [MarshalAs (UnmanagedType.I1)] out bool isClosed, out SKPathDirection direction);


		public delegate bool sk_path_is_oval_2 (sk_path_t cpath, nullptr_t boundsZero);


		public delegate bool sk_path_is_line_2 (sk_path_t cpath, nullptr_t lineZero);


		public delegate bool sk_path_is_rect_2 (sk_path_t cpath, nullptr_t rectZero, nullptr_t isClosedZero, nullptr_t directionZero);

		// path measure

		public delegate sk_pathmeasure_t sk_pathmeasure_new ();

		public delegate sk_pathmeasure_t sk_pathmeasure_new_with_path (sk_path_t path, [MarshalAs (UnmanagedType.I1)]bool forceClosed, float resScale);

		public delegate void sk_pathmeasure_destroy (sk_pathmeasure_t pathMeasure);

		public delegate void sk_pathmeasure_set_path (sk_pathmeasure_t pathMeasure, sk_path_t path, [MarshalAs (UnmanagedType.I1)] bool forceClosed);

		public delegate float sk_pathmeasure_get_length (sk_pathmeasure_t pathMeasure);


		public delegate bool sk_pathmeasure_get_pos_tan (sk_pathmeasure_t pathMeasure, float distance, out SKPoint position, out SKPoint tangent);


		public delegate bool sk_pathmeasure_get_pos_tan_2 (sk_pathmeasure_t pathMeasure, float distance, nullptr_t positionZero, out SKPoint tangent);


		public delegate bool sk_pathmeasure_get_pos_tan_3 (sk_pathmeasure_t pathMeasure, float distance, out SKPoint position, nullptr_t tangentZero);


		public delegate bool sk_pathmeasure_get_matrix (sk_pathmeasure_t pathMeasure, float distance, out SKMatrix matrix, SKPathMeasureMatrixFlags flags);


		public delegate bool sk_pathmeasure_get_segment (sk_pathmeasure_t pathMeasure, float start, float stop, sk_path_t dst, [MarshalAs (UnmanagedType.I1)] bool startWithMoveTo);


		public delegate bool sk_pathmeasure_is_closed (sk_pathmeasure_t pathMeasure);


		public delegate bool sk_pathmeasure_next_contour (sk_pathmeasure_t pathMeasure);

		// path ops


		public delegate bool sk_pathop_op (sk_path_t one, sk_path_t two, SKPathOp op, sk_path_t result);


		public delegate bool sk_pathop_simplify (sk_path_t path, sk_path_t result);


		public delegate bool sk_pathop_tight_bounds (sk_path_t path, out SKRect result);

		// path op builder

		public delegate sk_opbuilder_t sk_opbuilder_new ();

		public delegate void sk_opbuilder_destroy (sk_opbuilder_t builder);

		public delegate void sk_opbuilder_add (sk_opbuilder_t builder, sk_path_t path, SKPathOp op);


		public delegate bool sk_opbuilder_resolve (sk_opbuilder_t builder, sk_path_t result);

		// iterator

		public delegate sk_path_iterator_t sk_path_create_iter (sk_path_t path, int forceClose);

		public delegate SKPathVerb sk_path_iter_next (sk_path_iterator_t iterator, [Out] SKPoint[] points, int doConsumeDegenerates, int exact);

		public delegate float sk_path_iter_conic_weight (sk_path_iterator_t iterator);

		public delegate int sk_path_iter_is_close_line (sk_path_iterator_t iterator);

		public delegate int sk_path_iter_is_closed_contour (sk_path_iterator_t iterator);

		public delegate void sk_path_iter_destroy (sk_path_t path);

		// Raw iterator

		public delegate sk_path_iterator_t sk_path_create_rawiter (sk_path_t path);

		public delegate SKPathVerb sk_path_rawiter_next (sk_path_iterator_t iterator, [Out] SKPoint[] points);

		public delegate SKPathVerb sk_path_rawiter_peek (sk_path_iterator_t iterator);

		public delegate float sk_path_rawiter_conic_weight (sk_path_iterator_t iterator);

		public delegate void sk_path_rawiter_destroy (sk_path_t path);

		// SkMaskFilter

		public delegate void sk_maskfilter_unref (sk_maskfilter_t t);

		public delegate sk_maskfilter_t sk_maskfilter_new_blur (SKBlurStyle style, float sigma);

		public delegate sk_maskfilter_t sk_maskfilter_new_blur_with_flags (SKBlurStyle style, float sigma, ref SKRect occluder, [MarshalAs (UnmanagedType.I1)] bool respectCTM);

		public delegate sk_maskfilter_t sk_maskfilter_new_table (byte[] table /*[256]*/);

		public delegate sk_maskfilter_t sk_maskfilter_new_gamma (float gamma);

		public delegate sk_maskfilter_t sk_maskfilter_new_clip (byte min, byte max);

		// SkImageFilter::CropRect

		public delegate sk_imagefilter_croprect_t sk_imagefilter_croprect_new ();

		public delegate sk_imagefilter_croprect_t sk_imagefilter_croprect_new_with_rect (ref SKRect rect, SKCropRectFlags flags);

		public delegate void sk_imagefilter_croprect_destructor (sk_imagefilter_croprect_t cropRect);

		public delegate void sk_imagefilter_croprect_get_rect (sk_imagefilter_croprect_t cropRect, out SKRect rect);

		public delegate SKCropRectFlags sk_imagefilter_croprect_get_flags (sk_imagefilter_croprect_t cropRect);

		// SkImageFilter

		public delegate void sk_imagefilter_unref (sk_imagefilter_t filter);

		public delegate sk_imagefilter_t sk_imagefilter_new_matrix (ref SKMatrix matrix, SKFilterQuality quality, sk_imagefilter_t input /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_alpha_threshold (sk_region_t region, float innerThreshold, float outerThreshold, sk_imagefilter_t input /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_blur (float sigmaX, float sigmaY, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_color_filter (sk_colorfilter_t cf, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_compose (sk_imagefilter_t outer, sk_imagefilter_t inner);

		public delegate sk_imagefilter_t sk_imagefilter_new_displacement_map_effect (SKDisplacementMapEffectChannelSelectorType xChannelSelector, SKDisplacementMapEffectChannelSelectorType yChannelSelector, float scale, sk_imagefilter_t displacement, sk_imagefilter_t color /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_drop_shadow (float dx, float dy, float sigmaX, float sigmaY, SKColor color, SKDropShadowImageFilterShadowMode shadowMode, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_distant_lit_diffuse (ref SKPoint3 direction, SKColor lightColor, float surfaceScale, float kd, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_point_lit_diffuse (ref SKPoint3 location, SKColor lightColor, float surfaceScale, float kd, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_spot_lit_diffuse (ref SKPoint3 location, ref SKPoint3 target, float specularExponent, float cutoffAngle, SKColor lightColor, float surfaceScale, float kd, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_distant_lit_specular (ref SKPoint3 direction, SKColor lightColor, float surfaceScale, float ks, float shininess, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_point_lit_specular (ref SKPoint3 location, SKColor lightColor, float surfaceScale, float ks, float shininess, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_spot_lit_specular (ref SKPoint3 location, ref SKPoint3 target, float specularExponent, float cutoffAngle, SKColor lightColor, float surfaceScale, float ks, float shininess, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_magnifier (ref SKRect src, float inset, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_matrix_convolution (ref SKSizeI kernelSize, float[] kernel, float gain, float bias, ref SKPointI kernelOffset, SKMatrixConvolutionTileMode tileMode, [MarshalAs (UnmanagedType.I1)] bool convolveAlpha, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_merge (sk_imagefilter_t[] filters, int count, sk_imagefilter_croprect_t cropRect /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_dilate (int radiusX, int radiusY, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_erode (int radiusX, int radiusY, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_offset (float dx, float dy, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_picture (sk_picture_t picture);

		public delegate sk_imagefilter_t sk_imagefilter_new_picture_with_croprect (sk_picture_t picture, ref SKRect cropRect);

		public delegate sk_imagefilter_t sk_imagefilter_new_tile (ref SKRect src, ref SKRect dst, sk_imagefilter_t input);

		public delegate sk_imagefilter_t sk_imagefilter_new_xfermode (SKBlendMode mode, sk_imagefilter_t background, sk_imagefilter_t foreground /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_arithmetic (float k1, float k2, float k3, float k4, [MarshalAs (UnmanagedType.I1)] bool enforcePMColor, sk_imagefilter_t background, sk_imagefilter_t foreground /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);

		public delegate sk_imagefilter_t sk_imagefilter_new_image_source (sk_image_t image, ref SKRect srcRect, ref SKRect dstRect, SKFilterQuality filterQuality);

		public delegate sk_imagefilter_t sk_imagefilter_new_image_source_default (sk_image_t image);

		public delegate sk_imagefilter_t sk_imagefilter_new_paint (sk_paint_t paint, sk_imagefilter_croprect_t cropRect /*NULL*/);

		// color filter

		public delegate void sk_colorfilter_unref (sk_colorfilter_t filter);

		public delegate sk_colorfilter_t sk_colorfilter_new_mode (SKColor c, SKBlendMode mode);

		public delegate sk_colorfilter_t sk_colorfilter_new_lighting (SKColor mul, SKColor add);

		public delegate sk_colorfilter_t sk_colorfilter_new_compose (sk_colorfilter_t outer, sk_colorfilter_t inner);

		public delegate sk_colorfilter_t sk_colorfilter_new_color_matrix (float[] array/*[20]*/);

		public delegate sk_colorfilter_t sk_colorfilter_new_luma_color ();

		public delegate sk_colorfilter_t sk_colorfilter_new_table (byte[] table/*[256]*/);

		public delegate sk_colorfilter_t sk_colorfilter_new_table_argb (byte[] tableA/*[256]*/, byte[] tableR/*[256]*/, byte[] tableG/*[256]*/, byte[] tableB/*[256]*/);

		public delegate sk_colorfilter_t sk_colorfilter_new_high_contrast (ref SKHighContrastConfig config);

		// data

		public delegate sk_data_t sk_data_new_empty ();

		public delegate sk_data_t sk_data_new_with_copy (voidptr_t src, size_t length);

		public delegate sk_data_t sk_data_new_with_copy_2 (byte[] src, size_t length);

		public delegate sk_data_t sk_data_new_subset (sk_data_t src, size_t offset, size_t length);

		public delegate sk_data_t sk_data_new_from_file (byte[] utf8path);

		public delegate sk_data_t sk_data_new_from_stream (sk_stream_t stream, size_t length);

		public delegate sk_data_t sk_data_new_with_proc (voidptr_t ptr, size_t length, SKDataReleaseDelegateProxyDelegate proc, voidptr_t ctx);

		public delegate void sk_data_unref (sk_data_t d);

		public delegate size_t sk_data_get_size (sk_data_t d);

		public delegate voidptr_t sk_data_get_data (sk_data_t d);

		public delegate sk_data_t sk_data_new_uninitialized (size_t size);

		// string

		public delegate sk_string_t sk_string_new_empty ();

		public delegate sk_string_t sk_string_new_with_copy (byte[] src, size_t length);

		public delegate void sk_string_destructor (sk_string_t skstring);

		public delegate size_t sk_string_get_size (sk_string_t skstring);

		public delegate voidptr_t sk_string_get_c_str (sk_string_t skstring);

		// picture

		public delegate void sk_picture_recorder_delete (sk_picture_recorder_t r);

		public delegate sk_picture_recorder_t sk_picture_recorder_new ();

		public delegate sk_canvas_t sk_picture_recorder_begin_recording (sk_picture_recorder_t r, ref SKRect rect);

		public delegate sk_picture_t sk_picture_recorder_end_recording (sk_picture_recorder_t r);

		public delegate sk_drawable_t sk_picture_recorder_end_recording_as_drawable (sk_picture_recorder_t r);

		public delegate sk_canvas_t sk_picture_get_recording_canvas (sk_picture_recorder_t r);

		public delegate void sk_picture_unref (sk_image_t t);

		public delegate uint sk_picture_get_unique_id (sk_picture_t p);

		public delegate void sk_picture_get_cull_rect (sk_picture_t p, out SKRect rect);

		// drawable

		public delegate sk_manageddrawable_t sk_manageddrawable_new ();

		public delegate void sk_manageddrawable_destroy (sk_manageddrawable_t t);

		public delegate void sk_manageddrawable_set_delegates (voidptr_t pDraw, voidptr_t pGetBounds, voidptr_t pNewPictureSnapshot);

		public delegate uint sk_drawable_get_generation_id (sk_drawable_t d);

		public delegate void sk_drawable_get_bounds (sk_drawable_t d, out SKRect rect);

		public delegate void sk_drawable_draw (sk_drawable_t d, sk_canvas_t c, ref SKMatrix matrix);

		public delegate sk_picture_t sk_drawable_new_picture_snapshot (sk_drawable_t d);

		public delegate void sk_drawable_notify_drawing_changed (sk_drawable_t d);

		// shader

		public delegate void sk_shader_unref (sk_shader_t t);

		public delegate sk_shader_t sk_shader_new_empty ();

		public delegate sk_shader_t sk_shader_new_color (SKColor color);

		public delegate sk_shader_t sk_shader_new_local_matrix (sk_shader_t proxy, ref SKMatrix matrix);

		public delegate sk_shader_t sk_shader_new_color_filter (sk_shader_t proxy, sk_colorfilter_t filter);

		public delegate sk_shader_t sk_shader_new_bitmap (sk_bitmap_t src, SKShaderTileMode tmx, SKShaderTileMode tmy, ref SKMatrix matrix);

		public delegate sk_shader_t sk_shader_new_bitmap_2 (sk_bitmap_t src, SKShaderTileMode tmx, SKShaderTileMode tmy, nullptr_t matrixZero);

		public delegate sk_shader_t sk_shader_new_linear_gradient ([In] SKPoint[] points, [In] SKColor[] colors, float[] colorPos, int count, SKShaderTileMode mode, ref SKMatrix matrix);

		public delegate sk_shader_t sk_shader_new_linear_gradient_2 ([In] SKPoint[] points, [In] SKColor[] colors, float[] colorPos, int count, SKShaderTileMode mode, nullptr_t matrixZero);

		public delegate sk_shader_t sk_shader_new_radial_gradient (ref SKPoint center, float radius, [In] SKColor[] colors, float[] colorPos, int count, SKShaderTileMode mode, ref SKMatrix matrix);

		public delegate sk_shader_t sk_shader_new_radial_gradient_2 (ref SKPoint center, float radius, [In] SKColor[] colors, float[] colorPos, int count, SKShaderTileMode mode, nullptr_t matrixZero);

		public delegate sk_shader_t sk_shader_new_sweep_gradient (ref SKPoint center, [In] SKColor[] colors, float[] colorPos, int count, SKShaderTileMode mode, float startAngle, float endAngle, nullptr_t matrixZero);

		public delegate sk_shader_t sk_shader_new_sweep_gradient_2 (ref SKPoint center, [In] SKColor[] colors, float[] colorPos, int count, SKShaderTileMode mode, float startAngle, float endAngle, ref SKMatrix matrix);

		public delegate sk_shader_t sk_shader_new_two_point_conical_gradient (ref SKPoint start, float startRadius, ref SKPoint end, float endRadius, [In] SKColor[] colors, float[] colorPos, int count, SKShaderTileMode mode, ref SKMatrix matrix);

		public delegate sk_shader_t sk_shader_new_two_point_conical_gradient_2 (ref SKPoint start, float startRadius, ref SKPoint end, float endRadius, [In] SKColor[] colors, float[] colorPos, int count, SKShaderTileMode mode, voidptr_t matrixZero);

		public delegate sk_shader_t sk_shader_new_linear_gradient_3 ([In] SKPoint[] points, [In] SKColor[] colors, nullptr_t colorPosZero, int count, SKShaderTileMode mode, ref SKMatrix matrix);

		public delegate sk_shader_t sk_shader_new_linear_gradient_4 ([In] SKPoint[] points, [In] SKColor[] colors, nullptr_t colorPosZero, int count, SKShaderTileMode mode, nullptr_t matrixZero);

		public delegate sk_shader_t sk_shader_new_radial_gradient_3 (ref SKPoint center, float radius, [In] SKColor[] colors, nullptr_t colorPosZero, int count, SKShaderTileMode mode, ref SKMatrix matrix);

		public delegate sk_shader_t sk_shader_new_radial_gradient_4 (ref SKPoint center, float radius, [In] SKColor[] colors, nullptr_t colorPosZero, int count, SKShaderTileMode mode, nullptr_t matrixZero);

		public delegate sk_shader_t sk_shader_new_sweep_gradient_3 (ref SKPoint center, [In] SKColor[] colors, nullptr_t colorPosZero, int count, SKShaderTileMode mode, float startAngle, float endAngle, nullptr_t matrixZero);

		public delegate sk_shader_t sk_shader_new_sweep_gradient_4 (ref SKPoint center, [In] SKColor[] colors, nullptr_t colorPosZero, int count, SKShaderTileMode mode, float startAngle, float endAngle, ref SKMatrix matrixZero);

		public delegate sk_shader_t sk_shader_new_two_point_conical_gradient_3 (ref SKPoint start, float startRadius, ref SKPoint end, float endRadius, [In] SKColor[] colors, nullptr_t colorPosZero, int count, SKShaderTileMode mode, ref SKMatrix matrix);

		public delegate sk_shader_t sk_shader_new_two_point_conical_gradient_4 (ref SKPoint start, float startRadius, ref SKPoint end, float endRadius, [In] SKColor[] colors, nullptr_t colorPosZero, int count, SKShaderTileMode mode, nullptr_t matrixZero);

		public delegate sk_shader_t sk_shader_new_perlin_noise_fractal_noise (float baseFrequencyX, float baseFrequencyY, int numOctaves, float seed, nullptr_t tileSizeZero);

		public delegate sk_shader_t sk_shader_new_perlin_noise_fractal_noise_2 (float baseFrequencyX, float baseFrequencyY, int numOctaves, float seed, ref SKPointI tileSize);

		public delegate sk_shader_t sk_shader_new_perlin_noise_turbulence (float baseFrequencyX, float baseFrequencyY, int numOctaves, float seed, nullptr_t tileSizeZero);

		public delegate sk_shader_t sk_shader_new_perlin_noise_turbulence_2 (float baseFrequencyX, float baseFrequencyY, int numOctaves, float seed, ref SKPointI tileSize);

		public delegate sk_shader_t sk_shader_new_compose (sk_shader_t shaderA, sk_shader_t shaderB);

		public delegate sk_shader_t sk_shader_new_compose_with_mode (sk_shader_t shaderA, sk_shader_t shaderB, SKBlendMode mode);

		// typeface

		public delegate sk_typeface_t sk_typeface_create_default ();

		public delegate sk_typeface_t sk_typeface_ref_default ();

		public delegate sk_typeface_t sk_typeface_create_from_name_with_font_style ([MarshalAs (UnmanagedType.LPStr)] string familyName, sk_fontstyle_t style);

		public delegate sk_typeface_t sk_typeface_create_from_file (byte[] utf8path, int index);

		public delegate sk_typeface_t sk_typeface_create_from_stream (sk_stream_assetstream_t stream, int index);

		public delegate void sk_typeface_unref (sk_typeface_t t);

		public delegate int sk_typeface_chars_to_glyphs (sk_typeface_t t, voidptr_t chars, SKEncoding encoding, UInt16* glyphPtr, int glyphCount);

		public delegate sk_string_t sk_typeface_get_family_name (sk_typeface_t typeface);

		public delegate int sk_typeface_count_tables (sk_typeface_t typeface);

		public delegate int sk_typeface_get_table_tags (sk_typeface_t typeface, sk_font_table_tag_t[] tags);

		public delegate size_t sk_typeface_get_table_size (sk_typeface_t typeface, sk_font_table_tag_t tag);

		public delegate voidptr_t sk_typeface_get_table_data (sk_typeface_t typeface, sk_font_table_tag_t tag, size_t offset, size_t length, byte* data);

		public delegate sk_fontstyle_t sk_typeface_get_fontstyle (sk_typeface_t typeface);

		public delegate int sk_typeface_get_font_weight (sk_typeface_t typeface);

		public delegate int sk_typeface_get_font_width (sk_typeface_t typeface);

		public delegate SKFontStyleSlant sk_typeface_get_font_slant (sk_typeface_t typeface);

		public delegate sk_stream_assetstream_t sk_typeface_open_stream (sk_typeface_t typeface, out int ttcIndex);

		public delegate int sk_typeface_get_units_per_em (sk_typeface_t typeface);

		// font manager

		public delegate sk_fontmgr_t sk_fontmgr_create_default ();

		public delegate sk_fontmgr_t sk_fontmgr_ref_default ();

		public delegate void sk_fontmgr_unref (sk_fontmgr_t fontmgr);

		public delegate int sk_fontmgr_count_families (sk_fontmgr_t fontmgr);

		public delegate void sk_fontmgr_get_family_name (sk_fontmgr_t fontmgr, int index, sk_string_t familyName);

		public delegate sk_typeface_t sk_fontmgr_match_family_style_character (sk_fontmgr_t fontmgr, [MarshalAs (UnmanagedType.LPStr)] string familyName, sk_fontstyle_t style, [In] [MarshalAs (UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] bcp47, int bcp47Count, int character);

		public delegate sk_fontstyleset_t sk_fontmgr_create_styleset (sk_fontmgr_t fontmgr, int index);

		public delegate sk_fontstyleset_t sk_fontmgr_match_family (sk_fontmgr_t fontmgr, [MarshalAs (UnmanagedType.LPStr)] string familyName);

		public delegate sk_typeface_t sk_fontmgr_match_family_style (sk_fontmgr_t fontmgr, [MarshalAs (UnmanagedType.LPStr)] string familyName, sk_fontstyle_t style);

		public delegate sk_typeface_t sk_fontmgr_match_face_style (sk_fontmgr_t fontmgr, sk_typeface_t face, sk_fontstyle_t style);

		public delegate sk_typeface_t sk_fontmgr_create_from_data (sk_fontmgr_t fontmgr, sk_data_t data, int index);

		public delegate sk_typeface_t sk_fontmgr_create_from_stream (sk_fontmgr_t fontmgr, sk_stream_assetstream_t stream, int index);

		public delegate sk_typeface_t sk_fontmgr_create_from_file (sk_fontmgr_t fontmgr, byte[] utf8path, int index);

		// font style

		public delegate sk_fontstyle_t sk_fontstyle_new (int weight, int width, SKFontStyleSlant slant);

		public delegate void sk_fontstyle_delete (sk_fontstyle_t fs);

		public delegate int sk_fontstyle_get_weight (sk_fontstyle_t fs);

		public delegate int sk_fontstyle_get_width (sk_fontstyle_t fs);

		public delegate SKFontStyleSlant sk_fontstyle_get_slant (sk_fontstyle_t fs);

		// font style set

		public delegate sk_fontstyleset_t sk_fontstyleset_create_empty ();

		public delegate void sk_fontstyleset_unref (sk_fontstyleset_t fss);

		public delegate int sk_fontstyleset_get_count (sk_fontstyleset_t fss);

		public delegate void sk_fontstyleset_get_style (sk_fontstyleset_t fss, int index, sk_fontstyle_t fs, sk_string_t style);

		public delegate sk_typeface_t sk_fontstyleset_create_typeface (sk_fontstyleset_t fss, int index);

		public delegate sk_typeface_t sk_fontstyleset_match_style (sk_fontstyleset_t fss, sk_fontstyle_t style);

		// streams

		public delegate void sk_memorystream_destroy (sk_stream_memorystream_t stream);

		public delegate void sk_filestream_destroy (sk_stream_filestream_t stream);

		public delegate void sk_stream_asset_destroy (sk_stream_assetstream_t stream);

		public delegate size_t sk_stream_read (sk_stream_t stream, voidptr_t buffer, size_t size);

		public delegate size_t sk_stream_peek (sk_stream_t stream, voidptr_t buffer, size_t size);

		public delegate size_t sk_stream_skip (sk_stream_t stream, size_t size);


		public delegate bool sk_stream_is_at_end (sk_stream_t stream);


		public delegate bool sk_stream_read_s8 (sk_stream_t stream, out sbyte buffer);


		public delegate bool sk_stream_read_s16 (sk_stream_t stream, out short buffer);


		public delegate bool sk_stream_read_s32 (sk_stream_t stream, out int buffer);


		public delegate bool sk_stream_read_u8 (sk_stream_t stream, out byte buffer);


		public delegate bool sk_stream_read_u16 (sk_stream_t stream, out ushort buffer);


		public delegate bool sk_stream_read_u32 (sk_stream_t stream, out uint buffer);


		public delegate bool sk_stream_read_bool (sk_stream_t stream, [MarshalAs (UnmanagedType.I1)] out bool buffer);


		public delegate bool sk_stream_rewind (sk_stream_t stream);


		public delegate bool sk_stream_has_position (sk_stream_t stream);

		public delegate size_t sk_stream_get_position (sk_stream_t stream);


		public delegate bool sk_stream_seek (sk_stream_t stream, size_t position);


		public delegate bool sk_stream_move (sk_stream_t stream, long offset);


		public delegate bool sk_stream_has_length (sk_stream_t stream);

		public delegate size_t sk_stream_get_length (sk_stream_t stream);

		public delegate voidptr_t sk_stream_get_memory_base (sk_stream_t cstream);

		public delegate sk_stream_filestream_t sk_filestream_new (byte[] utf8path);

		public delegate sk_stream_memorystream_t sk_memorystream_new ();

		public delegate sk_stream_memorystream_t sk_memorystream_new_with_length (size_t length);

		public delegate sk_stream_memorystream_t sk_memorystream_new_with_data (voidptr_t data, size_t length, [MarshalAs (UnmanagedType.I1)] bool copyData);

		public delegate sk_stream_memorystream_t sk_memorystream_new_with_data_2 (byte[] data, size_t length, [MarshalAs (UnmanagedType.I1)] bool copyData);

		public delegate sk_stream_memorystream_t sk_memorystream_new_with_skdata (voidptr_t data);

		public delegate void sk_memorystream_set_memory (sk_stream_memorystream_t s, voidptr_t data, size_t length, [MarshalAs (UnmanagedType.I1)] bool copyData);

		public delegate void sk_memorystream_set_memory_2 (sk_stream_memorystream_t s, byte[] data, size_t length, [MarshalAs (UnmanagedType.I1)] bool copyData);


		public delegate bool sk_filestream_is_valid (sk_stream_filestream_t cstream);

		// managed streams

		public delegate sk_stream_managedstream_t sk_managedstream_new ();

		public delegate void sk_managedstream_set_delegates (voidptr_t pRead, voidptr_t pPeek, voidptr_t pIsAtEnd, voidptr_t pHasPosition, voidptr_t pHasLength, voidptr_t pRewind, voidptr_t pGetPosition, voidptr_t pSeek, voidptr_t pMove, voidptr_t pGetLength, voidptr_t pCreateNew, voidptr_t pDestroy);

		public delegate void sk_managedstream_destroy (sk_stream_managedstream_t stream);

		public delegate sk_wstream_managedstream_t sk_managedwstream_new ();

		public delegate void sk_managedwstream_destroy (sk_wstream_managedstream_t stream);

		public delegate void sk_managedwstream_set_delegates (voidptr_t pWrite, voidptr_t pFlush, voidptr_t pBytesWritten, voidptr_t pDestroy);

		// writeable streams

		public delegate void sk_filewstream_destroy (sk_wstream_filestream_t cstream);

		public delegate void sk_dynamicmemorywstream_destroy (sk_wstream_dynamicmemorystream_t cstream);

		public delegate sk_wstream_filestream_t sk_filewstream_new (byte[] utf8path);

		public delegate sk_wstream_dynamicmemorystream_t sk_dynamicmemorywstream_new ();

		public delegate sk_stream_assetstream_t sk_dynamicmemorywstream_detach_as_stream (sk_wstream_dynamicmemorystream_t cstream);

		public delegate sk_data_t sk_dynamicmemorywstream_detach_as_data (sk_wstream_dynamicmemorystream_t cstream);

		public delegate void sk_dynamicmemorywstream_copy_to (sk_wstream_dynamicmemorystream_t cstream, voidptr_t data);


		public delegate bool sk_dynamicmemorywstream_write_to_stream (sk_wstream_dynamicmemorystream_t cstream, sk_wstream_t dst);


		public delegate bool sk_wstream_write (sk_wstream_t cstream, voidptr_t buffer, size_t size);


		public delegate bool sk_wstream_write_2 (sk_wstream_t cstream, byte[] buffer, size_t size);


		public delegate bool sk_wstream_newline (sk_wstream_t cstream);

		public delegate void sk_wstream_flush (sk_wstream_t cstream);

		public delegate size_t sk_wstream_bytes_written (sk_wstream_t cstream);


		public delegate bool sk_wstream_write_8 (sk_wstream_t cstream, byte value);


		public delegate bool sk_wstream_write_16 (sk_wstream_t cstream, ushort value);


		public delegate bool sk_wstream_write_32 (sk_wstream_t cstream, uint value);


		public delegate bool sk_wstream_write_text (sk_wstream_t cstream, [MarshalAs (UnmanagedType.LPStr)] string value);


		public delegate bool sk_wstream_write_dec_as_text (sk_wstream_t cstream, int value);


		public delegate bool sk_wstream_write_bigdec_as_text (sk_wstream_t cstream, long value, int minDigits);


		public delegate bool sk_wstream_write_hex_as_text (sk_wstream_t cstream, uint value, int minDigits);


		public delegate bool sk_wstream_write_scalar_as_text (sk_wstream_t cstream, float value);


		public delegate bool sk_wstream_write_bool (sk_wstream_t cstream, [MarshalAs (UnmanagedType.I1)] bool value);


		public delegate bool sk_wstream_write_scalar (sk_wstream_t cstream, float value);


		public delegate bool sk_wstream_write_packed_uint (sk_wstream_t cstream, size_t value);


		public delegate bool sk_wstream_write_stream (sk_wstream_t cstream, sk_stream_t input, size_t length);

		public delegate int sk_wstream_get_size_of_packed_uint (size_t value);


		public delegate bool sk_filewstream_is_valid (sk_wstream_filestream_t cstream);

		// document

		public delegate void sk_document_unref (sk_document_t document);

		public delegate sk_document_t sk_document_create_pdf_from_stream (sk_wstream_t stream);

		public delegate sk_document_t sk_document_create_pdf_from_stream_with_metadata (sk_wstream_t stream, ref SKDocumentPdfMetadataInternal metadata);

		public delegate sk_document_t sk_document_create_xps_from_stream (sk_wstream_t stream, float dpi);

		public delegate sk_canvas_t sk_document_begin_page (sk_document_t document, float width, float height, ref SKRect content);

		public delegate sk_canvas_t sk_document_begin_page_2 (sk_document_t document, float width, float height, nullptr_t contentZero);

		public delegate void sk_document_end_page (sk_document_t document);

		public delegate void sk_document_close (sk_document_t document);

		public delegate void sk_document_abort (sk_document_t document);

		// codec

		public delegate size_t sk_codec_min_buffered_bytes_needed ();

		public delegate sk_codec_t sk_codec_new_from_stream (sk_stream_t stream, out SKCodecResult result);

		public delegate sk_codec_t sk_codec_new_from_data (sk_data_t data);

		public delegate void sk_codec_destroy (sk_codec_t codec);

		public delegate void sk_codec_get_info (sk_codec_t codec, out SKImageInfoNative info);

		public delegate SKEncodedOrigin sk_codec_get_origin (sk_codec_t codec);

		public delegate void sk_codec_get_scaled_dimensions (sk_codec_t codec, float desiredScale, out SKSizeI dimensions);


		public delegate bool sk_codec_get_valid_subset (sk_codec_t codec, ref SKRectI desiredSubset);

		public delegate SKEncodedImageFormat sk_codec_get_encoded_format (sk_codec_t codec);

		public delegate SKCodecResult sk_codec_get_pixels (sk_codec_t codec, ref SKImageInfoNative info, voidptr_t pixels, size_t rowBytes, ref SKCodecOptionsInternal options);

		public delegate SKCodecResult sk_codec_start_incremental_decode (sk_codec_t codec, ref SKImageInfoNative info, voidptr_t pixels, size_t rowBytes, ref SKCodecOptionsInternal options);

		public delegate SKCodecResult sk_codec_start_incremental_decode_2 (sk_codec_t codec, ref SKImageInfoNative info, voidptr_t pixels, size_t rowBytes, nullptr_t optionsZero);

		public delegate SKCodecResult sk_codec_incremental_decode (sk_codec_t codec, out int rowsDecoded);

		public delegate int sk_codec_get_repetition_count (sk_codec_t codec);

		public delegate int sk_codec_get_frame_count (sk_codec_t codec);

		public delegate void sk_codec_get_frame_info (sk_codec_t codec, [Out] SKCodecFrameInfo[] frameInfo);


		public delegate bool sk_codec_get_frame_info_for_index (sk_codec_t codec, int index, out SKCodecFrameInfo frameInfo);

		public delegate SKCodecResult sk_codec_start_scanline_decode (sk_codec_t codec, ref SKImageInfoNative info, ref SKCodecOptionsInternal options);

		public delegate SKCodecResult sk_codec_start_scanline_decode_2 (sk_codec_t codec, ref SKImageInfoNative info, nullptr_t optionsZero);

		public delegate int sk_codec_get_scanlines (sk_codec_t codec, voidptr_t dst, int countLines, size_t rowBytes);


		public delegate bool sk_codec_skip_scanlines (sk_codec_t codec, int countLines);

		public delegate SKCodecScanlineOrder sk_codec_get_scanline_order (sk_codec_t codec);

		public delegate int sk_codec_next_scanline (sk_codec_t codec);

		public delegate int sk_codec_output_scanline (sk_codec_t codec, int inputScanline);

		// bitmap

		public delegate sk_bitmap_t sk_bitmap_new ();

		public delegate void sk_bitmap_destructor (sk_bitmap_t b);

		public delegate void sk_bitmap_get_info (sk_bitmap_t b, out SKImageInfoNative info);

		public delegate voidptr_t sk_bitmap_get_pixels (sk_bitmap_t b, out size_t length);

		public delegate void sk_bitmap_get_pixel_colors (sk_bitmap_t b, [Out] SKColor[] colors);

		public delegate void sk_bitmap_set_pixel_colors (sk_bitmap_t b, [In] SKColor[] colors);

		public delegate void sk_bitmap_reset (sk_bitmap_t b);

		public delegate size_t sk_bitmap_get_row_bytes (sk_bitmap_t b);

		public delegate size_t sk_bitmap_get_byte_count (sk_bitmap_t b);


		public delegate bool sk_bitmap_is_null (sk_bitmap_t b);


		public delegate bool sk_bitmap_is_immutable (sk_bitmap_t b);

		public delegate void sk_bitmap_set_immutable (sk_bitmap_t b);


		public delegate bool sk_bitmap_is_volatile (sk_bitmap_t b);

		public delegate void sk_bitmap_set_volatile (sk_bitmap_t b, [MarshalAs (UnmanagedType.I1)] bool value);

		public delegate void sk_bitmap_erase (sk_bitmap_t cbitmap, SKColor color);

		public delegate void sk_bitmap_erase_rect (sk_bitmap_t cbitmap, SKColor color, ref SKRectI rect);

		public delegate byte sk_bitmap_get_addr_8 (sk_bitmap_t cbitmap, int x, int y);

		public delegate ushort sk_bitmap_get_addr_16 (sk_bitmap_t cbitmap, int x, int y);

		public delegate uint sk_bitmap_get_addr_32 (sk_bitmap_t cbitmap, int x, int y);

		public delegate voidptr_t sk_bitmap_get_addr (sk_bitmap_t cbitmap, int x, int y);

		public delegate sk_color_t sk_bitmap_get_pixel_color (sk_bitmap_t cbitmap, int x, int y);

		public delegate void sk_bitmap_set_pixel_color (sk_bitmap_t cbitmap, int x, int y, SKColor color);


		public delegate bool sk_bitmap_ready_to_draw (sk_bitmap_t b);


		public delegate bool sk_bitmap_install_pixels (sk_bitmap_t cbitmap, ref SKImageInfoNative cinfo, voidptr_t pixels, size_t rowBytes, SKBitmapReleaseDelegateProxyDelegate releaseProc, voidptr_t context);


		public delegate bool sk_bitmap_install_pixels_with_pixmap (sk_bitmap_t cbitmap, sk_pixmap_t cpixmap);


		public delegate bool sk_bitmap_install_mask_pixels (sk_bitmap_t cbitmap, ref SKMask cmask);


		public delegate bool sk_bitmap_try_alloc_pixels (sk_bitmap_t cbitmap, ref SKImageInfoNative requestedInfo, size_t rowBytes);


		public delegate bool sk_bitmap_try_alloc_pixels_with_flags (sk_bitmap_t cbitmap, ref SKImageInfoNative requestedInfo, SKBitmapAllocFlags flags);

		public delegate void sk_bitmap_set_pixels (sk_bitmap_t cbitmap, voidptr_t pixels);


		public delegate bool sk_bitmap_peek_pixels (sk_bitmap_t cbitmap, sk_pixmap_t cpixmap);


		public delegate bool sk_bitmap_extract_subset (sk_bitmap_t cbitmap, sk_bitmap_t cdst, ref SKRectI subset);


		public delegate bool sk_bitmap_extract_alpha (sk_bitmap_t cbitmap, sk_bitmap_t dst, sk_paint_t paint, out SKPointI offset);

		public delegate void sk_bitmap_notify_pixels_changed (sk_bitmap_t cbitmap);

		public delegate void sk_bitmap_swap (sk_bitmap_t cbitmap, sk_bitmap_t cother);

		// color

		public delegate sk_color_t sk_color_unpremultiply (SKPMColor pmcolor);

		public delegate sk_pmcolor_t sk_color_premultiply (SKColor color);

		public delegate void sk_color_unpremultiply_array (SKPMColor[] pmcolors, int size, [Out] SKColor[] colors);

		public delegate sk_pmcolor_t sk_color_premultiply_array (SKColor[] colors, int size, [Out] SKPMColor[] pmcolors);

		public delegate void sk_color_get_bit_shift (out int a, out int r, out int g, out int b);

		// pixmap

		public delegate void sk_pixmap_destructor (sk_pixmap_t cpixmap);

		public delegate sk_pixmap_t sk_pixmap_new ();

		public delegate sk_pixmap_t sk_pixmap_new_with_params (ref SKImageInfoNative cinfo, voidptr_t addr, size_t rowBytes);

		public delegate void sk_pixmap_reset (sk_pixmap_t cpixmap);

		public delegate void sk_pixmap_reset_with_params (sk_pixmap_t cpixmap, ref SKImageInfoNative cinfo, voidptr_t addr, size_t rowBytes);

		public delegate void sk_pixmap_get_info (sk_pixmap_t cpixmap, out SKImageInfoNative cinfo);

		public delegate size_t sk_pixmap_get_row_bytes (sk_pixmap_t cpixmap);

		public delegate voidptr_t sk_pixmap_get_pixels (sk_pixmap_t cpixmap);

		public delegate voidptr_t sk_pixmap_get_pixels_with_xy (sk_pixmap_t cpixmap, int x, int y);

		public delegate sk_color_t sk_pixmap_get_pixel_color (sk_pixmap_t t, int x, int y);


		public delegate bool sk_pixmap_extract_subset (sk_pixmap_t cpixmap, sk_pixmap_t result, ref SKRectI subset);


		public delegate bool sk_pixmap_erase_color (sk_pixmap_t cpixmap, SKColor color, ref SKRectI subset);


		public delegate bool sk_pixmap_encode_image (sk_wstream_t dst, sk_pixmap_t src, SKEncodedImageFormat encoder, int quality);


		public delegate bool sk_pixmap_read_pixels (sk_pixmap_t cpixmap, ref SKImageInfoNative dstInfo, voidptr_t dstPixels, size_t dstRowBytes, int srcX, int srcY, SKTransferFunctionBehavior behavior);


		public delegate bool sk_pixmap_scale_pixels (sk_pixmap_t cpixmap, sk_pixmap_t dst, SKFilterQuality quality);

		// swizzle

		public delegate void sk_swizzle_swap_rb (voidptr_t dest, voidptr_t src, int count);

		// webp encoder


		public delegate bool sk_webpencoder_encode (sk_wstream_t dst, sk_pixmap_t src, SKWebpEncoderOptions options);

		// jpeg encoder


		public delegate bool sk_jpegencoder_encode (sk_wstream_t dst, sk_pixmap_t src, SKJpegEncoderOptions options);

		// png encoder


		public delegate bool sk_pngencoder_encode (sk_wstream_t dst, sk_pixmap_t src, SKPngEncoderOptions options);

		// mask

		public delegate voidptr_t sk_mask_alloc_image (size_t bytes);

		public delegate void sk_mask_free_image (voidptr_t image);


		public delegate bool sk_mask_is_empty (ref SKMask cmask);

		public delegate size_t sk_mask_compute_image_size (ref SKMask cmask);

		public delegate size_t sk_mask_compute_total_image_size (ref SKMask cmask);

		public delegate byte sk_mask_get_addr_1 (ref SKMask cmask, int x, int y);

		public delegate byte sk_mask_get_addr_8 (ref SKMask cmask, int x, int y);

		public delegate UInt16 sk_mask_get_addr_lcd_16 (ref SKMask cmask, int x, int y);

		public delegate UInt32 sk_mask_get_addr_32 (ref SKMask cmask, int x, int y);

		public delegate voidptr_t sk_mask_get_addr (ref SKMask cmask, int x, int y);

		// matrix


		public delegate bool sk_matrix_try_invert (ref SKMatrix matrix, out SKMatrix result);

		public delegate void sk_matrix_concat (ref SKMatrix target, ref SKMatrix first, ref SKMatrix second);

		public delegate void sk_matrix_pre_concat (ref SKMatrix target, ref SKMatrix matrix);

		public delegate void sk_matrix_post_concat (ref SKMatrix target, ref SKMatrix matrix);

		public delegate void sk_matrix_map_rect (ref SKMatrix matrix, out SKRect dest, ref SKRect source);

		public delegate void sk_matrix_map_points (ref SKMatrix matrix, voidptr_t dst, voidptr_t src, int count);

		public delegate void sk_matrix_map_vectors (ref SKMatrix matrix, voidptr_t dst, voidptr_t src, int count);

		public delegate void sk_matrix_map_xy (ref SKMatrix matrix, float x, float y, out SKPoint result);

		public delegate void sk_matrix_map_vector (ref SKMatrix matrix, float x, float y, out SKPoint result);

		public delegate float sk_matrix_map_radius (ref SKMatrix matrix, float radius);

		// 3d view

		public delegate sk_3dview_t sk_3dview_new ();

		public delegate void sk_3dview_destroy (sk_3dview_t cview);

		public delegate void sk_3dview_save (sk_3dview_t cview);

		public delegate void sk_3dview_restore (sk_3dview_t cview);

		public delegate void sk_3dview_translate (sk_3dview_t cview, float x, float y, float z);

		public delegate void sk_3dview_rotate_x_degrees (sk_3dview_t cview, float degrees);

		public delegate void sk_3dview_rotate_y_degrees (sk_3dview_t cview, float degrees);

		public delegate void sk_3dview_rotate_z_degrees (sk_3dview_t cview, float degrees);

		public delegate void sk_3dview_rotate_x_radians (sk_3dview_t cview, float radians);

		public delegate void sk_3dview_rotate_y_radians (sk_3dview_t cview, float radians);

		public delegate void sk_3dview_rotate_z_radians (sk_3dview_t cview, float radians);

		public delegate void sk_3dview_get_matrix (sk_3dview_t cview, ref SKMatrix cmatrix);

		public delegate void sk_3dview_apply_to_canvas (sk_3dview_t cview, sk_canvas_t ccanvas);

		public delegate float sk_3dview_dot_with_normal (sk_3dview_t cview, float dx, float dy, float dz);

		// matrix44

		public delegate void sk_matrix44_destroy (sk_matrix44_t matrix);

		public delegate sk_matrix44_t sk_matrix44_new ();

		public delegate sk_matrix44_t sk_matrix44_new_identity ();

		public delegate sk_matrix44_t sk_matrix44_new_copy (sk_matrix44_t src);

		public delegate sk_matrix44_t sk_matrix44_new_concat (sk_matrix44_t a, sk_matrix44_t b);

		public delegate sk_matrix44_t sk_matrix44_new_matrix (ref SKMatrix src);


		public delegate bool sk_matrix44_equals (sk_matrix44_t matrix, sk_matrix44_t other);

		public delegate void sk_matrix44_to_matrix (sk_matrix44_t matrix, out SKMatrix dst);

		public delegate SKMatrix44TypeMask sk_matrix44_get_type (sk_matrix44_t matrix);

		public delegate void sk_matrix44_set_identity (sk_matrix44_t matrix);

		public delegate float sk_matrix44_get (sk_matrix44_t matrix, int row, int col);

		public delegate void sk_matrix44_set (sk_matrix44_t matrix, int row, int col, float value);

		public delegate void sk_matrix44_as_col_major (sk_matrix44_t matrix, [Out] float[] dst);

		public delegate void sk_matrix44_as_row_major (sk_matrix44_t matrix, [Out] float[] dst);

		public delegate void sk_matrix44_set_col_major (sk_matrix44_t matrix, [In] float[] src);

		public delegate void sk_matrix44_set_row_major (sk_matrix44_t matrix, [In] float[] src);

		public delegate void sk_matrix44_set_translate (sk_matrix44_t matrix, float dx, float dy, float dz);

		public delegate void sk_matrix44_pre_translate (sk_matrix44_t matrix, float dx, float dy, float dz);

		public delegate void sk_matrix44_post_translate (sk_matrix44_t matrix, float dx, float dy, float dz);

		public delegate void sk_matrix44_set_scale (sk_matrix44_t matrix, float sx, float sy, float sz);

		public delegate void sk_matrix44_pre_scale (sk_matrix44_t matrix, float sx, float sy, float sz);

		public delegate void sk_matrix44_post_scale (sk_matrix44_t matrix, float sx, float sy, float sz);

		public delegate void sk_matrix44_set_rotate_about_degrees (sk_matrix44_t matrix, float x, float y, float z, float degrees);

		public delegate void sk_matrix44_set_rotate_about_radians (sk_matrix44_t matrix, float x, float y, float z, float radians);

		public delegate void sk_matrix44_set_rotate_about_radians_unit (sk_matrix44_t matrix, float x, float y, float z, float radians);

		public delegate void sk_matrix44_set_concat (sk_matrix44_t matrix, sk_matrix44_t a, sk_matrix44_t b);

		public delegate void sk_matrix44_pre_concat (sk_matrix44_t matrix, sk_matrix44_t m);

		public delegate void sk_matrix44_post_concat (sk_matrix44_t matrix, sk_matrix44_t m);


		public delegate bool sk_matrix44_invert (sk_matrix44_t matrix, sk_matrix44_t inverse);

		public delegate void sk_matrix44_transpose (sk_matrix44_t matrix);

		public delegate void sk_matrix44_map_scalars (sk_matrix44_t matrix, [In] float[] src, float[] dst);

		public delegate void sk_matrix44_map2 (sk_matrix44_t matrix, [In] float[] src2, int count, float[] dst);


		public delegate bool sk_matrix44_preserves_2d_axis_alignment (sk_matrix44_t matrix, float epsilon);

		public delegate double sk_matrix44_determinant (sk_matrix44_t matrix);

		// path effect

		public delegate void sk_path_effect_unref (sk_path_effect_t effect);

		public delegate sk_path_effect_t sk_path_effect_create_compose (sk_path_effect_t outer, sk_path_effect_t inner);

		public delegate sk_path_effect_t sk_path_effect_create_sum (sk_path_effect_t first, sk_path_effect_t second);

		public delegate sk_path_effect_t sk_path_effect_create_discrete (float segLength, float deviation, UInt32 seedAssist /*0*/);

		public delegate sk_path_effect_t sk_path_effect_create_corner (float radius);

		public delegate sk_path_effect_t sk_path_effect_create_1d_path (sk_path_t path, float advance, float phase, SKPath1DPathEffectStyle style);

		public delegate sk_path_effect_t sk_path_effect_create_2d_line (float width, ref SKMatrix matrix);

		public delegate sk_path_effect_t sk_path_effect_create_2d_path (ref SKMatrix matrix, sk_path_t path);

		public delegate sk_path_effect_t sk_path_effect_create_dash (float[] intervals, int count, float phase);

		public delegate sk_path_effect_t sk_path_effect_create_trim (float start, float stop, SKTrimPathEffectMode mode);

		// color table

		public delegate void sk_colortable_unref (sk_colortable_t ctable);

		public delegate sk_colortable_t sk_colortable_new ([In] SKPMColor[] colors, int count);

		public delegate int sk_colortable_count (sk_colortable_t ctable);

		public delegate void sk_colortable_read_colors (sk_colortable_t ctable, out IntPtr colors);

		// GPU context

		public delegate gr_context_t gr_context_make_gl (gr_glinterface_t glInterface);

		public delegate void gr_context_unref (gr_context_t context);

		public delegate void gr_context_abandon_context (gr_context_t context);

		public delegate void gr_context_release_resources_and_abandon_context (gr_context_t context);

		public delegate void gr_context_get_resource_cache_limits (gr_context_t context, out int maxResources, out size_t maxResourceBytes);

		public delegate void gr_context_set_resource_cache_limits (gr_context_t context, int maxResources, size_t maxResourceBytes);

		public delegate void gr_context_get_resource_cache_usage (gr_context_t context, out int maxResources, out size_t maxResourceBytes);

		public delegate int gr_context_get_max_surface_sample_count_for_color_type (gr_context_t context, SKColorType colorType);

		public delegate void gr_context_flush (gr_context_t context);

		public delegate void gr_context_reset_context (gr_context_t context, UInt32 state);

		public delegate GRBackend gr_context_get_backend (gr_context_t context);

		// GL interface

		public delegate gr_glinterface_t gr_glinterface_assemble_interface (voidptr_t ctx, GRGlGetProcDelegateProxyDelegate get);

		public delegate gr_glinterface_t gr_glinterface_assemble_gl_interface (voidptr_t ctx, GRGlGetProcDelegateProxyDelegate get);

		public delegate gr_glinterface_t gr_glinterface_assemble_gles_interface (voidptr_t ctx, GRGlGetProcDelegateProxyDelegate get);

		public delegate gr_glinterface_t gr_glinterface_create_native_interface ();

		public delegate void gr_glinterface_unref (gr_glinterface_t glInterface);


		public delegate bool gr_glinterface_validate (gr_glinterface_t glInterface);


		public delegate bool gr_glinterface_has_extension (gr_glinterface_t glInterface, [MarshalAs (UnmanagedType.LPStr)] string extension);

		// GPU backend texture

		public delegate gr_backendtexture_t gr_backendtexture_new_gl (int width, int height, [MarshalAs (UnmanagedType.I1)] bool mipmapped, ref GRGlTextureInfo glInfo);

		public delegate void gr_backendtexture_delete (gr_backendtexture_t texture);


		public delegate bool gr_backendtexture_is_valid (gr_backendtexture_t texture);

		public delegate int gr_backendtexture_get_width (gr_backendtexture_t texture);

		public delegate int gr_backendtexture_get_height (gr_backendtexture_t texture);


		public delegate bool gr_backendtexture_has_mipmaps (gr_backendtexture_t texture);

		public delegate GRBackend gr_backendtexture_get_backend (gr_backendtexture_t texture);


		public delegate bool gr_backendtexture_get_gl_textureinfo (gr_backendtexture_t texture, out GRGlTextureInfo glInfo);

		// GPU backend render target

		public delegate gr_backendrendertarget_t gr_backendrendertarget_new_gl (int width, int height, int samples, int stencils, ref GRGlFramebufferInfo glInfo);

		public delegate void gr_backendrendertarget_delete (gr_backendrendertarget_t rendertarget);


		public delegate bool gr_backendrendertarget_is_valid (gr_backendrendertarget_t rendertarget);

		public delegate int gr_backendrendertarget_get_width (gr_backendrendertarget_t rendertarget);

		public delegate int gr_backendrendertarget_get_height (gr_backendrendertarget_t rendertarget);

		public delegate int gr_backendrendertarget_get_samples (gr_backendrendertarget_t rendertarget);

		public delegate int gr_backendrendertarget_get_stencils (gr_backendrendertarget_t rendertarget);

		public delegate GRBackend gr_backendrendertarget_get_backend (gr_backendrendertarget_t rendertarget);


		public delegate bool gr_backendrendertarget_get_gl_framebufferinfo (gr_backendrendertarget_t rendertarget, out GRGlFramebufferInfo glInfo);

		// xml

		public delegate sk_xmlstreamwriter_t sk_xmlstreamwriter_new (sk_wstream_t stream);

		public delegate void sk_xmlstreamwriter_delete (sk_xmlstreamwriter_t writer);

		// svg

		public delegate sk_canvas_t sk_svgcanvas_create (ref SKRect bounds, sk_xmlwriter_t writer);

		// region

		public delegate sk_region_t sk_region_new ();

		public delegate sk_region_t sk_region_new2 (sk_region_t r);


		public delegate bool sk_region_contains (sk_region_t r, sk_region_t region);


		public delegate bool sk_region_contains2 (sk_region_t r, int x, int y);


		public delegate bool sk_region_intersects (sk_region_t r, sk_region_t src);


		public delegate bool sk_region_intersects_rect (sk_region_t r, ref SKRectI rect);


		public delegate bool sk_region_set_region (sk_region_t r, sk_region_t src);


		public delegate bool sk_region_set_rect (sk_region_t r, ref SKRectI rect);


		public delegate bool sk_region_set_path (sk_region_t r, sk_path_t t, sk_region_t clip);


		public delegate bool sk_region_op (sk_region_t r, int left, int top, int right, int bottom, SKRegionOperation op);


		public delegate bool sk_region_op2 (sk_region_t r, sk_region_t src, SKRegionOperation op);

		public delegate void sk_region_get_bounds (sk_region_t r, out SKRectI rect);

		// vertices

		public delegate void sk_vertices_unref (sk_vertices_t cvertices);

		public delegate sk_vertices_t sk_vertices_make_copy (SKVertexMode vmode, int vertexCount, [In] SKPoint[] positions, [In] SKPoint[] texs, [In] SKColor[] colors, int indexCount, [In] UInt16[] indices);

		// round rect

		public delegate sk_rrect_t sk_rrect_new ();

		public delegate sk_rrect_t sk_rrect_new_copy (sk_rrect_t rrect);

		public delegate void sk_rrect_delete (sk_rrect_t rrect);

		public delegate SKRoundRectType sk_rrect_get_type (sk_rrect_t rrect);

		public delegate void sk_rrect_get_rect (sk_rrect_t rrect, out SKRect rect);

		public delegate void sk_rrect_get_radii (sk_rrect_t rrect, SKRoundRectCorner corner, [Out] out SKPoint radii);

		public delegate float sk_rrect_get_width (sk_rrect_t rrect);

		public delegate float sk_rrect_get_height (sk_rrect_t rrect);

		public delegate void sk_rrect_set_empty (sk_rrect_t rrect);

		public delegate void sk_rrect_set_rect (sk_rrect_t rrect, [In] ref SKRect rect);

		public delegate void sk_rrect_set_oval (sk_rrect_t rrect, [In] ref SKRect rect);

		public delegate void sk_rrect_set_rect_xy (sk_rrect_t rrect, [In] ref SKRect rect, float xRad, float yRad);

		public delegate void sk_rrect_set_nine_patch (sk_rrect_t rrect, [In] ref SKRect rect, float leftRad, float topRad, float rightRad, float bottomRad);

		public delegate void sk_rrect_set_rect_radii (sk_rrect_t rrect, [In] ref SKRect rect, [In] SKPoint[] radii);

		public delegate void sk_rrect_inset (sk_rrect_t rrect, float dx, float dy);

		public delegate void sk_rrect_outset (sk_rrect_t rrect, float dx, float dy);

		public delegate void sk_rrect_offset (sk_rrect_t rrect, float dx, float dy);


		public delegate bool sk_rrect_contains (sk_rrect_t rrect, [In] ref SKRect rect);


		public delegate bool sk_rrect_is_valid (sk_rrect_t rrect);


		public delegate bool sk_rrect_transform (sk_rrect_t rrect, [In] ref SKMatrix matrix, sk_rrect_t dest);

		// text blob

		public delegate void sk_textblob_ref (sk_textblob_t blob);

		public delegate void sk_textblob_unref (sk_textblob_t blob);

		public delegate UInt32 sk_textblob_get_unique_id (sk_textblob_t blob);

		public delegate void sk_textblob_get_bounds (sk_textblob_t blob, out SKRect bounds);

		// text blob builder

		public delegate sk_textblob_builder_t sk_textblob_builder_new ();

		public delegate void sk_textblob_builder_delete (sk_textblob_builder_t builder);

		public delegate sk_textblob_t sk_textblob_builder_make (sk_textblob_builder_t builder);

		public delegate void sk_textblob_builder_alloc_run_text (sk_textblob_builder_t builder, sk_paint_t font, int count, float x, float y, int textByteCount, sk_string_t lang, SKRect* bounds, out SKRunBufferInternal runbuffer);

		public delegate void sk_textblob_builder_alloc_run_text_pos_h (sk_textblob_builder_t builder, sk_paint_t font, int count, float y, int textByteCount, sk_string_t lang, SKRect* bounds, out SKRunBufferInternal runbuffer);

		public delegate void sk_textblob_builder_alloc_run_text_pos (sk_textblob_builder_t builder, sk_paint_t font, int count, int textByteCount, sk_string_t lang, SKRect* bounds, out SKRunBufferInternal runbuffer);



	}

	internal static unsafe class SkiaApi
	{

		public static SkiaApiDelegates.sk_colorspace_unref sk_colorspace_unref = DefaultInterop.sk_colorspace_unref;

		public static SkiaApiDelegates.sk_colorspace_gamma_close_to_srgb sk_colorspace_gamma_close_to_srgb = DefaultInterop.sk_colorspace_gamma_close_to_srgb;

		public static SkiaApiDelegates.sk_colorspace_gamma_is_linear sk_colorspace_gamma_is_linear = DefaultInterop.sk_colorspace_gamma_is_linear;

		public static SkiaApiDelegates.sk_colorspace_is_srgb sk_colorspace_is_srgb = DefaultInterop.sk_colorspace_is_srgb;

		public static SkiaApiDelegates.sk_colorspace_gamma_get_type sk_colorspace_gamma_get_type = DefaultInterop.sk_colorspace_gamma_get_type;

		public static SkiaApiDelegates.sk_colorspace_gamma_get_gamma_named sk_colorspace_gamma_get_gamma_named = DefaultInterop.sk_colorspace_gamma_get_gamma_named;


		public static SkiaApiDelegates.sk_colorspace_equals sk_colorspace_equals = DefaultInterop.sk_colorspace_equals;

		public static SkiaApiDelegates.sk_colorspace_new_srgb sk_colorspace_new_srgb = DefaultInterop.sk_colorspace_new_srgb;

		public static SkiaApiDelegates.sk_colorspace_new_srgb_linear sk_colorspace_new_srgb_linear = DefaultInterop.sk_colorspace_new_srgb_linear;

		public static SkiaApiDelegates.sk_colorspace_new_icc sk_colorspace_new_icc = DefaultInterop.sk_colorspace_new_icc;

		public static SkiaApiDelegates.sk_colorspace_new_icc_2 sk_colorspace_new_icc_2 = DefaultInterop.sk_colorspace_new_icc;

		public static SkiaApiDelegates.sk_colorspace_new_rgb_with_gamma sk_colorspace_new_rgb_with_gamma = DefaultInterop.sk_colorspace_new_rgb_with_gamma;

		public static SkiaApiDelegates.sk_colorspace_new_rgb_with_gamma_and_gamut sk_colorspace_new_rgb_with_gamma_and_gamut = DefaultInterop.sk_colorspace_new_rgb_with_gamma_and_gamut;

		public static SkiaApiDelegates.sk_colorspace_new_rgb_with_coeffs sk_colorspace_new_rgb_with_coeffs = DefaultInterop.sk_colorspace_new_rgb_with_coeffs;

		public static SkiaApiDelegates.sk_colorspace_new_rgb_with_coeffs_and_gamut sk_colorspace_new_rgb_with_coeffs_and_gamut = DefaultInterop.sk_colorspace_new_rgb_with_coeffs_and_gamut;

		public static SkiaApiDelegates.sk_colorspace_new_rgb_with_gamma_named sk_colorspace_new_rgb_with_gamma_named = DefaultInterop.sk_colorspace_new_rgb_with_gamma_named;

		public static SkiaApiDelegates.sk_colorspace_new_rgb_with_gamma_named_and_gamut sk_colorspace_new_rgb_with_gamma_named_and_gamut = DefaultInterop.sk_colorspace_new_rgb_with_gamma_named_and_gamut;


		public static SkiaApiDelegates.sk_colorspace_to_xyzd50 sk_colorspace_to_xyzd50 = DefaultInterop.sk_colorspace_to_xyzd50;

		public static SkiaApiDelegates.sk_colorspace_as_to_xyzd50 sk_colorspace_as_to_xyzd50 = DefaultInterop.sk_colorspace_as_to_xyzd50;

		public static SkiaApiDelegates.sk_colorspace_as_from_xyzd50 sk_colorspace_as_from_xyzd50 = DefaultInterop.sk_colorspace_as_from_xyzd50;


		public static SkiaApiDelegates.sk_colorspace_is_numerical_transfer_fn sk_colorspace_is_numerical_transfer_fn = DefaultInterop.sk_colorspace_is_numerical_transfer_fn;


		public static SkiaApiDelegates.sk_colorspaceprimaries_to_xyzd50 sk_colorspaceprimaries_to_xyzd50 = DefaultInterop.sk_colorspaceprimaries_to_xyzd50;

		public static SkiaApiDelegates.sk_colorspace_transfer_fn_invert sk_colorspace_transfer_fn_invert = DefaultInterop.sk_colorspace_transfer_fn_invert;

		public static SkiaApiDelegates.sk_colorspace_transfer_fn_transform sk_colorspace_transfer_fn_transform = DefaultInterop.sk_colorspace_transfer_fn_transform;

		// color type

		public static SkiaApiDelegates.sk_colortype_get_default_8888 sk_colortype_get_default_8888 = DefaultInterop.sk_colortype_get_default_8888;

		// surface

		public static SkiaApiDelegates.sk_surface_new_null sk_surface_new_null = DefaultInterop.sk_surface_new_null;

		public static SkiaApiDelegates.sk_surface_unref sk_surface_unref = DefaultInterop.sk_surface_unref;

		public static SkiaApiDelegates.sk_surface_new_raster sk_surface_new_raster = DefaultInterop.sk_surface_new_raster;

		public static SkiaApiDelegates.sk_surface_new_raster_direct sk_surface_new_raster_direct = DefaultInterop.sk_surface_new_raster_direct;

		public static SkiaApiDelegates.sk_surface_get_canvas sk_surface_get_canvas = DefaultInterop.sk_surface_get_canvas;

		public static SkiaApiDelegates.sk_surface_new_image_snapshot sk_surface_new_image_snapshot = DefaultInterop.sk_surface_new_image_snapshot;

		public static SkiaApiDelegates.sk_surface_new_backend_render_target sk_surface_new_backend_render_target = DefaultInterop.sk_surface_new_backend_render_target;

		public static SkiaApiDelegates.sk_surface_new_backend_texture sk_surface_new_backend_texture = DefaultInterop.sk_surface_new_backend_texture;

		public static SkiaApiDelegates.sk_surface_new_backend_texture_as_render_target sk_surface_new_backend_texture_as_render_target = DefaultInterop.sk_surface_new_backend_texture_as_render_target;

		public static SkiaApiDelegates.sk_surface_new_render_target sk_surface_new_render_target = DefaultInterop.sk_surface_new_render_target;

		public static SkiaApiDelegates.sk_surface_draw sk_surface_draw = DefaultInterop.sk_surface_draw;


		public static SkiaApiDelegates.sk_surface_peek_pixels sk_surface_peek_pixels = DefaultInterop.sk_surface_peek_pixels;


		public static SkiaApiDelegates.sk_surface_read_pixels sk_surface_read_pixels = DefaultInterop.sk_surface_read_pixels;

		public static SkiaApiDelegates.sk_surface_get_props sk_surface_get_props = DefaultInterop.sk_surface_get_props;

		// surface props

		public static SkiaApiDelegates.sk_surfaceprops_new sk_surfaceprops_new = DefaultInterop.sk_surfaceprops_new;

		public static SkiaApiDelegates.sk_surfaceprops_delete sk_surfaceprops_delete = DefaultInterop.sk_surfaceprops_delete;

		public static SkiaApiDelegates.sk_surfaceprops_get_flags sk_surfaceprops_get_flags = DefaultInterop.sk_surfaceprops_get_flags;

		public static SkiaApiDelegates.sk_surfaceprops_get_pixel_geometry sk_surfaceprops_get_pixel_geometry = DefaultInterop.sk_surfaceprops_get_pixel_geometry;

		// canvas

		public static SkiaApiDelegates.sk_canvas_save sk_canvas_save = DefaultInterop.sk_canvas_save;

		public static SkiaApiDelegates.sk_canvas_save_layer sk_canvas_save_layer = DefaultInterop.sk_canvas_save_layer;

		public static SkiaApiDelegates.sk_canvas_save_layer_2 sk_canvas_save_layer_2 = DefaultInterop.sk_canvas_save_layer;

		public static SkiaApiDelegates.sk_canvas_restore sk_canvas_restore = DefaultInterop.sk_canvas_restore;

		public static SkiaApiDelegates.sk_canvas_get_save_count sk_canvas_get_save_count = DefaultInterop.sk_canvas_get_save_count;

		public static SkiaApiDelegates.sk_canvas_restore_to_count sk_canvas_restore_to_count = DefaultInterop.sk_canvas_restore_to_count;

		public static SkiaApiDelegates.sk_canvas_translate sk_canvas_translate = DefaultInterop.sk_canvas_translate;

		public static SkiaApiDelegates.sk_canvas_scale sk_canvas_scale = DefaultInterop.sk_canvas_scale;

		public static SkiaApiDelegates.sk_canvas_rotate_degrees sk_canvas_rotate_degrees = DefaultInterop.sk_canvas_rotate_degrees;

		public static SkiaApiDelegates.sk_canvas_rotate_radians sk_canvas_rotate_radians = DefaultInterop.sk_canvas_rotate_radians;

		public static SkiaApiDelegates.sk_canvas_skew sk_canvas_skew = DefaultInterop.sk_canvas_skew;

		public static SkiaApiDelegates.sk_canvas_concat sk_canvas_concat = DefaultInterop.sk_canvas_concat;


		public static SkiaApiDelegates.sk_canvas_quick_reject sk_canvas_quick_reject = DefaultInterop.sk_canvas_quick_reject;

		public static SkiaApiDelegates.sk_canvas_draw_paint sk_canvas_draw_paint = DefaultInterop.sk_canvas_draw_paint;

		public static SkiaApiDelegates.sk_canvas_draw_region sk_canvas_draw_region = DefaultInterop.sk_canvas_draw_region;

		public static SkiaApiDelegates.sk_canvas_draw_rect sk_canvas_draw_rect = DefaultInterop.sk_canvas_draw_rect;

		public static SkiaApiDelegates.sk_canvas_draw_rrect sk_canvas_draw_rrect = DefaultInterop.sk_canvas_draw_rrect;

		public static SkiaApiDelegates.sk_canvas_draw_round_rect sk_canvas_draw_round_rect = DefaultInterop.sk_canvas_draw_round_rect;

		public static SkiaApiDelegates.sk_canvas_draw_oval sk_canvas_draw_oval = DefaultInterop.sk_canvas_draw_oval;

		public static SkiaApiDelegates.sk_canvas_draw_circle sk_canvas_draw_circle = DefaultInterop.sk_canvas_draw_circle;

		public static SkiaApiDelegates.sk_canvas_draw_path sk_canvas_draw_path = DefaultInterop.sk_canvas_draw_path;

		public static SkiaApiDelegates.sk_canvas_draw_image sk_canvas_draw_image = DefaultInterop.sk_canvas_draw_image;

		public static SkiaApiDelegates.sk_canvas_draw_image_rect sk_canvas_draw_image_rect = DefaultInterop.sk_canvas_draw_image_rect;

		public static SkiaApiDelegates.sk_canvas_draw_image_rect_2 sk_canvas_draw_image_rect_2 = DefaultInterop.sk_canvas_draw_image_rect;

		public static SkiaApiDelegates.sk_canvas_draw_picture sk_canvas_draw_picture = DefaultInterop.sk_canvas_draw_picture;

		public static SkiaApiDelegates.sk_canvas_draw_picture_2 sk_canvas_draw_picture_2 = DefaultInterop.sk_canvas_draw_picture;

		public static SkiaApiDelegates.sk_canvas_draw_drawable sk_canvas_draw_drawable = DefaultInterop.sk_canvas_draw_drawable;

		public static SkiaApiDelegates.sk_canvas_draw_color sk_canvas_draw_color = DefaultInterop.sk_canvas_draw_color;

		public static SkiaApiDelegates.sk_canvas_draw_points sk_canvas_draw_points = DefaultInterop.sk_canvas_draw_points;

		public static SkiaApiDelegates.sk_canvas_draw_point sk_canvas_draw_point = DefaultInterop.sk_canvas_draw_point;

		public static SkiaApiDelegates.sk_canvas_draw_line sk_canvas_draw_line = DefaultInterop.sk_canvas_draw_line;

		public static SkiaApiDelegates.sk_canvas_draw_text sk_canvas_draw_text = DefaultInterop.sk_canvas_draw_text;

		public static SkiaApiDelegates.sk_canvas_draw_pos_text sk_canvas_draw_pos_text = DefaultInterop.sk_canvas_draw_pos_text;

		public static SkiaApiDelegates.sk_canvas_draw_text_on_path sk_canvas_draw_text_on_path = DefaultInterop.sk_canvas_draw_text_on_path;

		public static SkiaApiDelegates.sk_canvas_draw_text_2 sk_canvas_draw_text_2 = DefaultInterop.sk_canvas_draw_text;

		public static SkiaApiDelegates.sk_canvas_draw_pos_text_2 sk_canvas_draw_pos_text_2 = DefaultInterop.sk_canvas_draw_pos_text;

		public static SkiaApiDelegates.sk_canvas_draw_text_on_path_2 sk_canvas_draw_text_on_path_2 = DefaultInterop.sk_canvas_draw_text_on_path;

		public static SkiaApiDelegates.sk_canvas_draw_text_blob sk_canvas_draw_text_blob = DefaultInterop.sk_canvas_draw_text_blob;

		public static SkiaApiDelegates.sk_canvas_draw_bitmap sk_canvas_draw_bitmap = DefaultInterop.sk_canvas_draw_bitmap;

		public static SkiaApiDelegates.sk_canvas_draw_bitmap_rect sk_canvas_draw_bitmap_rect = DefaultInterop.sk_canvas_draw_bitmap_rect;

		public static SkiaApiDelegates.sk_canvas_draw_bitmap_rect_2 sk_canvas_draw_bitmap_rect_2 = DefaultInterop.sk_canvas_draw_bitmap_rect;

		public static SkiaApiDelegates.sk_canvas_reset_matrix sk_canvas_reset_matrix = DefaultInterop.sk_canvas_reset_matrix;

		public static SkiaApiDelegates.sk_canvas_set_matrix sk_canvas_set_matrix = DefaultInterop.sk_canvas_set_matrix;

		public static SkiaApiDelegates.sk_canvas_get_total_matrix sk_canvas_get_total_matrix = DefaultInterop.sk_canvas_get_total_matrix;

		public static SkiaApiDelegates.sk_canvas_draw_annotation sk_canvas_draw_annotation = DefaultInterop.sk_canvas_draw_annotation;

		public static SkiaApiDelegates.sk_canvas_draw_url_annotation sk_canvas_draw_url_annotation = DefaultInterop.sk_canvas_draw_url_annotation;

		public static SkiaApiDelegates.sk_canvas_draw_named_destination_annotation sk_canvas_draw_named_destination_annotation = DefaultInterop.sk_canvas_draw_named_destination_annotation;

		public static SkiaApiDelegates.sk_canvas_draw_link_destination_annotation sk_canvas_draw_link_destination_annotation = DefaultInterop.sk_canvas_draw_link_destination_annotation;

		public static SkiaApiDelegates.sk_canvas_clip_rrect_with_operation sk_canvas_clip_rrect_with_operation = DefaultInterop.sk_canvas_clip_rrect_with_operation;

		public static SkiaApiDelegates.sk_canvas_clip_rect_with_operation sk_canvas_clip_rect_with_operation = DefaultInterop.sk_canvas_clip_rect_with_operation;

		public static SkiaApiDelegates.sk_canvas_clip_path_with_operation sk_canvas_clip_path_with_operation = DefaultInterop.sk_canvas_clip_path_with_operation;

		public static SkiaApiDelegates.sk_canvas_clip_region sk_canvas_clip_region = DefaultInterop.sk_canvas_clip_region;


		public static SkiaApiDelegates.sk_canvas_get_device_clip_bounds sk_canvas_get_device_clip_bounds = DefaultInterop.sk_canvas_get_device_clip_bounds;


		public static SkiaApiDelegates.sk_canvas_get_local_clip_bounds sk_canvas_get_local_clip_bounds = DefaultInterop.sk_canvas_get_local_clip_bounds;

		public static SkiaApiDelegates.sk_canvas_new_from_bitmap sk_canvas_new_from_bitmap = DefaultInterop.sk_canvas_new_from_bitmap;

		public static SkiaApiDelegates.sk_canvas_flush sk_canvas_flush = DefaultInterop.sk_canvas_flush;

		public static SkiaApiDelegates.sk_canvas_draw_bitmap_lattice sk_canvas_draw_bitmap_lattice = DefaultInterop.sk_canvas_draw_bitmap_lattice;

		public static SkiaApiDelegates.sk_canvas_draw_image_lattice sk_canvas_draw_image_lattice = DefaultInterop.sk_canvas_draw_image_lattice;

		public static SkiaApiDelegates.sk_canvas_draw_bitmap_nine sk_canvas_draw_bitmap_nine = DefaultInterop.sk_canvas_draw_bitmap_nine;

		public static SkiaApiDelegates.sk_canvas_draw_image_nine sk_canvas_draw_image_nine = DefaultInterop.sk_canvas_draw_image_nine;

		public static SkiaApiDelegates.sk_canvas_destroy sk_canvas_destroy = DefaultInterop.sk_canvas_destroy;

		public static SkiaApiDelegates.sk_canvas_draw_vertices sk_canvas_draw_vertices = DefaultInterop.sk_canvas_draw_vertices;

		// no draw canvas

		public static SkiaApiDelegates.sk_nodraw_canvas_new sk_nodraw_canvas_new = DefaultInterop.sk_nodraw_canvas_new;

		public static SkiaApiDelegates.sk_nodraw_canvas_destroy sk_nodraw_canvas_destroy = DefaultInterop.sk_nodraw_canvas_destroy;

		// n-way canvas

		public static SkiaApiDelegates.sk_nway_canvas_new sk_nway_canvas_new = DefaultInterop.sk_nway_canvas_new;

		public static SkiaApiDelegates.sk_nway_canvas_destroy sk_nway_canvas_destroy = DefaultInterop.sk_nway_canvas_destroy;

		public static SkiaApiDelegates.sk_nway_canvas_add_canvas sk_nway_canvas_add_canvas = DefaultInterop.sk_nway_canvas_add_canvas;

		public static SkiaApiDelegates.sk_nway_canvas_remove_canvas sk_nway_canvas_remove_canvas = DefaultInterop.sk_nway_canvas_remove_canvas;

		public static SkiaApiDelegates.sk_nway_canvas_remove_all sk_nway_canvas_remove_all = DefaultInterop.sk_nway_canvas_remove_all;

		// overdraw canvas

		public static SkiaApiDelegates.sk_overdraw_canvas_new sk_overdraw_canvas_new = DefaultInterop.sk_overdraw_canvas_new;

		public static SkiaApiDelegates.sk_overdraw_canvas_destroy sk_overdraw_canvas_destroy = DefaultInterop.sk_overdraw_canvas_destroy;

		// paint

		public static SkiaApiDelegates.sk_paint_new sk_paint_new = DefaultInterop.sk_paint_new;

		public static SkiaApiDelegates.sk_paint_delete sk_paint_delete = DefaultInterop.sk_paint_delete;

		public static SkiaApiDelegates.sk_paint_reset sk_paint_reset = DefaultInterop.sk_paint_reset;


		public static SkiaApiDelegates.sk_paint_is_antialias sk_paint_is_antialias = DefaultInterop.sk_paint_is_antialias;

		public static SkiaApiDelegates.sk_paint_set_antialias sk_paint_set_antialias = DefaultInterop.sk_paint_set_antialias;


		public static SkiaApiDelegates.sk_paint_is_dither sk_paint_is_dither = DefaultInterop.sk_paint_is_dither;

		public static SkiaApiDelegates.sk_paint_set_dither sk_paint_set_dither = DefaultInterop.sk_paint_set_dither;


		public static SkiaApiDelegates.sk_paint_is_verticaltext sk_paint_is_verticaltext = DefaultInterop.sk_paint_is_verticaltext;

		public static SkiaApiDelegates.sk_paint_set_verticaltext sk_paint_set_verticaltext = DefaultInterop.sk_paint_set_verticaltext;

		public static SkiaApiDelegates.sk_paint_get_color sk_paint_get_color = DefaultInterop.sk_paint_get_color;

		public static SkiaApiDelegates.sk_paint_set_color sk_paint_set_color = DefaultInterop.sk_paint_set_color;

		public static SkiaApiDelegates.sk_paint_get_style sk_paint_get_style = DefaultInterop.sk_paint_get_style;

		public static SkiaApiDelegates.sk_paint_set_style sk_paint_set_style = DefaultInterop.sk_paint_set_style;

		public static SkiaApiDelegates.sk_paint_get_stroke_width sk_paint_get_stroke_width = DefaultInterop.sk_paint_get_stroke_width;

		public static SkiaApiDelegates.sk_paint_set_stroke_width sk_paint_set_stroke_width = DefaultInterop.sk_paint_set_stroke_width;

		public static SkiaApiDelegates.sk_paint_get_stroke_miter sk_paint_get_stroke_miter = DefaultInterop.sk_paint_get_stroke_miter;

		public static SkiaApiDelegates.sk_paint_set_stroke_miter sk_paint_set_stroke_miter = DefaultInterop.sk_paint_set_stroke_miter;

		public static SkiaApiDelegates.sk_paint_get_stroke_cap sk_paint_get_stroke_cap = DefaultInterop.sk_paint_get_stroke_cap;

		public static SkiaApiDelegates.sk_paint_set_stroke_cap sk_paint_set_stroke_cap = DefaultInterop.sk_paint_set_stroke_cap;

		public static SkiaApiDelegates.sk_paint_get_stroke_join sk_paint_get_stroke_join = DefaultInterop.sk_paint_get_stroke_join;

		public static SkiaApiDelegates.sk_paint_set_stroke_join sk_paint_set_stroke_join = DefaultInterop.sk_paint_set_stroke_join;

		public static SkiaApiDelegates.sk_paint_set_shader sk_paint_set_shader = DefaultInterop.sk_paint_set_shader;

		public static SkiaApiDelegates.sk_paint_get_shader sk_paint_get_shader = DefaultInterop.sk_paint_get_shader;

		public static SkiaApiDelegates.sk_paint_set_maskfilter sk_paint_set_maskfilter = DefaultInterop.sk_paint_set_maskfilter;

		public static SkiaApiDelegates.sk_paint_get_maskfilter sk_paint_get_maskfilter = DefaultInterop.sk_paint_get_maskfilter;

		public static SkiaApiDelegates.sk_paint_set_colorfilter sk_paint_set_colorfilter = DefaultInterop.sk_paint_set_colorfilter;

		public static SkiaApiDelegates.sk_paint_get_colorfilter sk_paint_get_colorfilter = DefaultInterop.sk_paint_get_colorfilter;

		public static SkiaApiDelegates.sk_paint_set_imagefilter sk_paint_set_imagefilter = DefaultInterop.sk_paint_set_imagefilter;

		public static SkiaApiDelegates.sk_paint_get_imagefilter sk_paint_get_imagefilter = DefaultInterop.sk_paint_get_imagefilter;

		public static SkiaApiDelegates.sk_paint_set_blendmode sk_paint_set_blendmode = DefaultInterop.sk_paint_set_blendmode;

		public static SkiaApiDelegates.sk_paint_get_blendmode sk_paint_get_blendmode = DefaultInterop.sk_paint_get_blendmode;

		public static SkiaApiDelegates.sk_paint_set_filter_quality sk_paint_set_filter_quality = DefaultInterop.sk_paint_set_filter_quality;

		public static SkiaApiDelegates.sk_paint_get_filter_quality sk_paint_get_filter_quality = DefaultInterop.sk_paint_get_filter_quality;

		public static SkiaApiDelegates.sk_paint_get_typeface sk_paint_get_typeface = DefaultInterop.sk_paint_get_typeface;

		public static SkiaApiDelegates.sk_paint_set_typeface sk_paint_set_typeface = DefaultInterop.sk_paint_set_typeface;

		public static SkiaApiDelegates.sk_paint_get_textsize sk_paint_get_textsize = DefaultInterop.sk_paint_get_textsize;

		public static SkiaApiDelegates.sk_paint_set_textsize sk_paint_set_textsize = DefaultInterop.sk_paint_set_textsize;

		public static SkiaApiDelegates.sk_paint_get_text_align sk_paint_get_text_align = DefaultInterop.sk_paint_get_text_align;

		public static SkiaApiDelegates.sk_paint_set_text_align sk_paint_set_text_align = DefaultInterop.sk_paint_set_text_align;

		public static SkiaApiDelegates.sk_paint_get_text_encoding sk_paint_get_text_encoding = DefaultInterop.sk_paint_get_text_encoding;

		public static SkiaApiDelegates.sk_paint_set_text_encoding sk_paint_set_text_encoding = DefaultInterop.sk_paint_set_text_encoding;

		public static SkiaApiDelegates.sk_paint_get_text_scale_x sk_paint_get_text_scale_x = DefaultInterop.sk_paint_get_text_scale_x;

		public static SkiaApiDelegates.sk_paint_set_text_scale_x sk_paint_set_text_scale_x = DefaultInterop.sk_paint_set_text_scale_x;

		public static SkiaApiDelegates.sk_paint_get_text_skew_x sk_paint_get_text_skew_x = DefaultInterop.sk_paint_get_text_skew_x;

		public static SkiaApiDelegates.sk_paint_set_text_skew_x sk_paint_set_text_skew_x = DefaultInterop.sk_paint_set_text_skew_x;

		public static SkiaApiDelegates.sk_paint_measure_text sk_paint_measure_text = DefaultInterop.sk_paint_measure_text;

		public static SkiaApiDelegates.sk_paint_measure_text_2 sk_paint_measure_text_2 = DefaultInterop.sk_paint_measure_text;

		public static SkiaApiDelegates.sk_paint_break_text sk_paint_break_text = DefaultInterop.sk_paint_break_text;

		public static SkiaApiDelegates.sk_paint_get_text_path sk_paint_get_text_path = DefaultInterop.sk_paint_get_text_path;

		public static SkiaApiDelegates.sk_paint_get_pos_text_path sk_paint_get_pos_text_path = DefaultInterop.sk_paint_get_pos_text_path;

		public static SkiaApiDelegates.sk_paint_get_fontmetrics sk_paint_get_fontmetrics = DefaultInterop.sk_paint_get_fontmetrics;

		public static SkiaApiDelegates.sk_paint_get_fontmetrics_2 sk_paint_get_fontmetrics_2 = DefaultInterop.sk_paint_get_fontmetrics;

		public static SkiaApiDelegates.sk_paint_get_path_effect sk_paint_get_path_effect = DefaultInterop.sk_paint_get_path_effect;

		public static SkiaApiDelegates.sk_paint_set_path_effect sk_paint_set_path_effect = DefaultInterop.sk_paint_set_path_effect;


		public static SkiaApiDelegates.sk_paint_is_linear_text sk_paint_is_linear_text = DefaultInterop.sk_paint_is_linear_text;

		public static SkiaApiDelegates.sk_paint_set_linear_text sk_paint_set_linear_text = DefaultInterop.sk_paint_set_linear_text;


		public static SkiaApiDelegates.sk_paint_is_subpixel_text sk_paint_is_subpixel_text = DefaultInterop.sk_paint_is_subpixel_text;

		public static SkiaApiDelegates.sk_paint_set_subpixel_text sk_paint_set_subpixel_text = DefaultInterop.sk_paint_set_subpixel_text;


		public static SkiaApiDelegates.sk_paint_is_lcd_render_text sk_paint_is_lcd_render_text = DefaultInterop.sk_paint_is_lcd_render_text;

		public static SkiaApiDelegates.sk_paint_set_lcd_render_text sk_paint_set_lcd_render_text = DefaultInterop.sk_paint_set_lcd_render_text;


		public static SkiaApiDelegates.sk_paint_is_embedded_bitmap_text sk_paint_is_embedded_bitmap_text = DefaultInterop.sk_paint_is_embedded_bitmap_text;

		public static SkiaApiDelegates.sk_paint_set_embedded_bitmap_text sk_paint_set_embedded_bitmap_text = DefaultInterop.sk_paint_set_embedded_bitmap_text;


		public static SkiaApiDelegates.sk_paint_is_autohinted sk_paint_is_autohinted = DefaultInterop.sk_paint_is_autohinted;

		public static SkiaApiDelegates.sk_paint_set_autohinted sk_paint_set_autohinted = DefaultInterop.sk_paint_set_autohinted;

		public static SkiaApiDelegates.sk_paint_get_hinting sk_paint_get_hinting = DefaultInterop.sk_paint_get_hinting;

		public static SkiaApiDelegates.sk_paint_set_hinting sk_paint_set_hinting = DefaultInterop.sk_paint_set_hinting;


		public static SkiaApiDelegates.sk_paint_is_fake_bold_text sk_paint_is_fake_bold_text = DefaultInterop.sk_paint_is_fake_bold_text;

		public static SkiaApiDelegates.sk_paint_set_fake_bold_text sk_paint_set_fake_bold_text = DefaultInterop.sk_paint_set_fake_bold_text;


		public static SkiaApiDelegates.sk_paint_is_dev_kern_text sk_paint_is_dev_kern_text = DefaultInterop.sk_paint_is_dev_kern_text;

		public static SkiaApiDelegates.sk_paint_set_dev_kern_text sk_paint_set_dev_kern_text = DefaultInterop.sk_paint_set_dev_kern_text;


		public static SkiaApiDelegates.sk_paint_get_fill_path sk_paint_get_fill_path = DefaultInterop.sk_paint_get_fill_path;


		public static SkiaApiDelegates.sk_paint_get_fill_path_2 sk_paint_get_fill_path_2 = DefaultInterop.sk_paint_get_fill_path;

		public static SkiaApiDelegates.sk_paint_clone sk_paint_clone = DefaultInterop.sk_paint_clone;

		public static SkiaApiDelegates.sk_paint_text_to_glyphs sk_paint_text_to_glyphs = DefaultInterop.sk_paint_text_to_glyphs;


		public static SkiaApiDelegates.sk_paint_contains_text sk_paint_contains_text = DefaultInterop.sk_paint_contains_text;

		public static SkiaApiDelegates.sk_paint_count_text sk_paint_count_text = DefaultInterop.sk_paint_count_text;

		public static SkiaApiDelegates.sk_paint_get_text_widths sk_paint_get_text_widths = DefaultInterop.sk_paint_get_text_widths;

		public static SkiaApiDelegates.sk_paint_get_text_intercepts sk_paint_get_text_intercepts = DefaultInterop.sk_paint_get_text_intercepts;

		public static SkiaApiDelegates.sk_paint_get_pos_text_intercepts sk_paint_get_pos_text_intercepts = DefaultInterop.sk_paint_get_pos_text_intercepts;

		public static SkiaApiDelegates.sk_paint_get_pos_text_h_intercepts sk_paint_get_pos_text_h_intercepts = DefaultInterop.sk_paint_get_pos_text_h_intercepts;

		public static SkiaApiDelegates.sk_paint_get_pos_text_blob_intercepts sk_paint_get_pos_text_blob_intercepts = DefaultInterop.sk_paint_get_pos_text_blob_intercepts;


		// image

		public static SkiaApiDelegates.sk_image_ref sk_image_ref = DefaultInterop.sk_image_ref;

		public static SkiaApiDelegates.sk_image_unref sk_image_unref = DefaultInterop.sk_image_unref;

		public static SkiaApiDelegates.sk_image_new_raster_copy sk_image_new_raster_copy = DefaultInterop.sk_image_new_raster_copy;

		public static SkiaApiDelegates.sk_image_new_raster_copy_with_pixmap sk_image_new_raster_copy_with_pixmap = DefaultInterop.sk_image_new_raster_copy_with_pixmap;

		public static SkiaApiDelegates.sk_image_new_raster_data sk_image_new_raster_data = DefaultInterop.sk_image_new_raster_data;

		public static SkiaApiDelegates.sk_image_new_raster sk_image_new_raster = DefaultInterop.sk_image_new_raster;

		public static SkiaApiDelegates.sk_image_new_from_bitmap sk_image_new_from_bitmap = DefaultInterop.sk_image_new_from_bitmap;

		public static SkiaApiDelegates.sk_image_new_from_encoded sk_image_new_from_encoded = DefaultInterop.sk_image_new_from_encoded;

		public static SkiaApiDelegates.sk_image_new_from_encoded_2 sk_image_new_from_encoded_2 = DefaultInterop.sk_image_new_from_encoded;

		public static SkiaApiDelegates.sk_image_new_from_texture sk_image_new_from_texture = DefaultInterop.sk_image_new_from_texture;

		public static SkiaApiDelegates.sk_image_new_from_adopted_texture sk_image_new_from_adopted_texture = DefaultInterop.sk_image_new_from_adopted_texture;

		public static SkiaApiDelegates.sk_image_new_from_picture sk_image_new_from_picture = DefaultInterop.sk_image_new_from_picture;

		public static SkiaApiDelegates.sk_image_new_from_picture_2 sk_image_new_from_picture_2 = DefaultInterop.sk_image_new_from_picture;

		public static SkiaApiDelegates.sk_image_get_width sk_image_get_width = DefaultInterop.sk_image_get_width;

		public static SkiaApiDelegates.sk_image_get_height sk_image_get_height = DefaultInterop.sk_image_get_height;

		public static SkiaApiDelegates.sk_image_get_unique_id sk_image_get_unique_id = DefaultInterop.sk_image_get_unique_id;

		public static SkiaApiDelegates.sk_image_get_alpha_type sk_image_get_alpha_type = DefaultInterop.sk_image_get_alpha_type;

		public static SkiaApiDelegates.sk_image_get_color_type sk_image_get_color_type = DefaultInterop.sk_image_get_color_type;

		public static SkiaApiDelegates.sk_image_get_colorspace sk_image_get_colorspace = DefaultInterop.sk_image_get_colorspace;


		public static SkiaApiDelegates.sk_image_is_alpha_only sk_image_is_alpha_only = DefaultInterop.sk_image_is_alpha_only;

		public static SkiaApiDelegates.sk_image_make_shader sk_image_make_shader = DefaultInterop.sk_image_make_shader;

		public static SkiaApiDelegates.sk_image_make_shader_2 sk_image_make_shader_2 = DefaultInterop.sk_image_make_shader;


		public static SkiaApiDelegates.sk_image_peek_pixels sk_image_peek_pixels = DefaultInterop.sk_image_peek_pixels;


		public static SkiaApiDelegates.sk_image_is_texture_backed sk_image_is_texture_backed = DefaultInterop.sk_image_is_texture_backed;


		public static SkiaApiDelegates.sk_image_is_lazy_generated sk_image_is_lazy_generated = DefaultInterop.sk_image_is_lazy_generated;


		public static SkiaApiDelegates.sk_image_read_pixels sk_image_read_pixels = DefaultInterop.sk_image_read_pixels;


		public static SkiaApiDelegates.sk_image_read_pixels_into_pixmap sk_image_read_pixels_into_pixmap = DefaultInterop.sk_image_read_pixels_into_pixmap;


		public static SkiaApiDelegates.sk_image_scale_pixels sk_image_scale_pixels = DefaultInterop.sk_image_scale_pixels;

		public static SkiaApiDelegates.sk_image_ref_encoded sk_image_ref_encoded = DefaultInterop.sk_image_ref_encoded;

		public static SkiaApiDelegates.sk_image_encode sk_image_encode = DefaultInterop.sk_image_encode;

		public static SkiaApiDelegates.sk_image_encode_specific sk_image_encode_specific = DefaultInterop.sk_image_encode_specific;

		public static SkiaApiDelegates.sk_image_make_subset sk_image_make_subset = DefaultInterop.sk_image_make_subset;

		public static SkiaApiDelegates.sk_image_make_non_texture_image sk_image_make_non_texture_image = DefaultInterop.sk_image_make_non_texture_image;

		public static SkiaApiDelegates.sk_image_make_with_filter sk_image_make_with_filter = DefaultInterop.sk_image_make_with_filter;

		// path


		public static SkiaApiDelegates.sk_path_contains sk_path_contains = DefaultInterop.sk_path_contains;


		public static SkiaApiDelegates.sk_path_get_last_point sk_path_get_last_point = DefaultInterop.sk_path_get_last_point;

		public static SkiaApiDelegates.sk_path_new sk_path_new = DefaultInterop.sk_path_new;

		public static SkiaApiDelegates.sk_path_delete sk_path_delete = DefaultInterop.sk_path_delete;

		public static SkiaApiDelegates.sk_path_move_to sk_path_move_to = DefaultInterop.sk_path_move_to;

		public static SkiaApiDelegates.sk_path_rmove_to sk_path_rmove_to = DefaultInterop.sk_path_rmove_to;

		public static SkiaApiDelegates.sk_path_line_to sk_path_line_to = DefaultInterop.sk_path_line_to;

		public static SkiaApiDelegates.sk_path_rline_to sk_path_rline_to = DefaultInterop.sk_path_rline_to;

		public static SkiaApiDelegates.sk_path_quad_to sk_path_quad_to = DefaultInterop.sk_path_quad_to;

		public static SkiaApiDelegates.sk_path_rquad_to sk_path_rquad_to = DefaultInterop.sk_path_rquad_to;

		public static SkiaApiDelegates.sk_path_conic_to sk_path_conic_to = DefaultInterop.sk_path_conic_to;

		public static SkiaApiDelegates.sk_path_rconic_to sk_path_rconic_to = DefaultInterop.sk_path_rconic_to;

		public static SkiaApiDelegates.sk_path_cubic_to sk_path_cubic_to = DefaultInterop.sk_path_cubic_to;

		public static SkiaApiDelegates.sk_path_rcubic_to sk_path_rcubic_to = DefaultInterop.sk_path_rcubic_to;

		public static SkiaApiDelegates.sk_path_close sk_path_close = DefaultInterop.sk_path_close;

		public static SkiaApiDelegates.sk_path_rewind sk_path_rewind = DefaultInterop.sk_path_rewind;

		public static SkiaApiDelegates.sk_path_reset sk_path_reset = DefaultInterop.sk_path_reset;

		public static SkiaApiDelegates.sk_path_add_rect sk_path_add_rect = DefaultInterop.sk_path_add_rect;

		public static SkiaApiDelegates.sk_path_add_rect_start sk_path_add_rect_start = DefaultInterop.sk_path_add_rect_start;

		public static SkiaApiDelegates.sk_path_add_rrect sk_path_add_rrect = DefaultInterop.sk_path_add_rrect;

		public static SkiaApiDelegates.sk_path_add_rrect_start sk_path_add_rrect_start = DefaultInterop.sk_path_add_rrect_start;

		public static SkiaApiDelegates.sk_path_add_oval sk_path_add_oval = DefaultInterop.sk_path_add_oval;

		public static SkiaApiDelegates.sk_path_add_arc sk_path_add_arc = DefaultInterop.sk_path_add_arc;

		public static SkiaApiDelegates.sk_path_add_path_offset sk_path_add_path_offset = DefaultInterop.sk_path_add_path_offset;

		public static SkiaApiDelegates.sk_path_add_path_matrix sk_path_add_path_matrix = DefaultInterop.sk_path_add_path_matrix;

		public static SkiaApiDelegates.sk_path_add_path sk_path_add_path = DefaultInterop.sk_path_add_path;

		public static SkiaApiDelegates.sk_path_add_path_reverse sk_path_add_path_reverse = DefaultInterop.sk_path_add_path_reverse;

		public static SkiaApiDelegates.sk_path_get_bounds sk_path_get_bounds = DefaultInterop.sk_path_get_bounds;

		public static SkiaApiDelegates.sk_path_compute_tight_bounds sk_path_compute_tight_bounds = DefaultInterop.sk_path_compute_tight_bounds;

		public static SkiaApiDelegates.sk_path_get_filltype sk_path_get_filltype = DefaultInterop.sk_path_get_filltype;

		public static SkiaApiDelegates.sk_path_set_filltype sk_path_set_filltype = DefaultInterop.sk_path_set_filltype;

		public static SkiaApiDelegates.sk_path_clone sk_path_clone = DefaultInterop.sk_path_clone;

		public static SkiaApiDelegates.sk_path_transform sk_path_transform = DefaultInterop.sk_path_transform;

		public static SkiaApiDelegates.sk_path_arc_to sk_path_arc_to = DefaultInterop.sk_path_arc_to;

		public static SkiaApiDelegates.sk_path_rarc_to sk_path_rarc_to = DefaultInterop.sk_path_rarc_to;

		public static SkiaApiDelegates.sk_path_arc_to_with_oval sk_path_arc_to_with_oval = DefaultInterop.sk_path_arc_to_with_oval;

		public static SkiaApiDelegates.sk_path_arc_to_with_points sk_path_arc_to_with_points = DefaultInterop.sk_path_arc_to_with_points;

		public static SkiaApiDelegates.sk_path_add_rounded_rect sk_path_add_rounded_rect = DefaultInterop.sk_path_add_rounded_rect;

		public static SkiaApiDelegates.sk_path_add_circle sk_path_add_circle = DefaultInterop.sk_path_add_circle;

		public static SkiaApiDelegates.sk_path_count_verbs sk_path_count_verbs = DefaultInterop.sk_path_count_verbs;

		public static SkiaApiDelegates.sk_path_count_points sk_path_count_points = DefaultInterop.sk_path_count_points;

		public static SkiaApiDelegates.sk_path_get_point sk_path_get_point = DefaultInterop.sk_path_get_point;

		public static SkiaApiDelegates.sk_path_get_points sk_path_get_points = DefaultInterop.sk_path_get_points;

		public static SkiaApiDelegates.sk_path_get_convexity sk_path_get_convexity = DefaultInterop.sk_path_get_convexity;

		public static SkiaApiDelegates.sk_path_set_convexity sk_path_set_convexity = DefaultInterop.sk_path_set_convexity;


		public static SkiaApiDelegates.sk_path_parse_svg_string sk_path_parse_svg_string = DefaultInterop.sk_path_parse_svg_string;

		public static SkiaApiDelegates.sk_path_to_svg_string sk_path_to_svg_string = DefaultInterop.sk_path_to_svg_string;

		public static SkiaApiDelegates.sk_path_convert_conic_to_quads sk_path_convert_conic_to_quads = DefaultInterop.sk_path_convert_conic_to_quads;

		public static SkiaApiDelegates.sk_path_add_poly sk_path_add_poly = DefaultInterop.sk_path_add_poly;

		public static SkiaApiDelegates.sk_path_get_segment_masks sk_path_get_segment_masks = DefaultInterop.sk_path_get_segment_masks;


		public static SkiaApiDelegates.sk_path_is_oval sk_path_is_oval = DefaultInterop.sk_path_is_oval;


		public static SkiaApiDelegates.sk_path_is_rrect sk_path_is_rrect = DefaultInterop.sk_path_is_rrect;


		public static SkiaApiDelegates.sk_path_is_line sk_path_is_line = DefaultInterop.sk_path_is_line;


		public static SkiaApiDelegates.sk_path_is_rect sk_path_is_rect = DefaultInterop.sk_path_is_rect;


		public static SkiaApiDelegates.sk_path_is_oval_2 sk_path_is_oval_2 = DefaultInterop.sk_path_is_oval;


		public static SkiaApiDelegates.sk_path_is_line_2 sk_path_is_line_2 = DefaultInterop.sk_path_is_line;


		public static SkiaApiDelegates.sk_path_is_rect_2 sk_path_is_rect_2 = DefaultInterop.sk_path_is_rect;

		// path measure

		public static SkiaApiDelegates.sk_pathmeasure_new sk_pathmeasure_new = DefaultInterop.sk_pathmeasure_new;

		public static SkiaApiDelegates.sk_pathmeasure_new_with_path sk_pathmeasure_new_with_path = DefaultInterop.sk_pathmeasure_new_with_path;

		public static SkiaApiDelegates.sk_pathmeasure_destroy sk_pathmeasure_destroy = DefaultInterop.sk_pathmeasure_destroy;

		public static SkiaApiDelegates.sk_pathmeasure_set_path sk_pathmeasure_set_path = DefaultInterop.sk_pathmeasure_set_path;

		public static SkiaApiDelegates.sk_pathmeasure_get_length sk_pathmeasure_get_length = DefaultInterop.sk_pathmeasure_get_length;


		public static SkiaApiDelegates.sk_pathmeasure_get_pos_tan sk_pathmeasure_get_pos_tan = DefaultInterop.sk_pathmeasure_get_pos_tan;


		public static SkiaApiDelegates.sk_pathmeasure_get_pos_tan_2 sk_pathmeasure_get_pos_tan_2 = DefaultInterop.sk_pathmeasure_get_pos_tan;


		public static SkiaApiDelegates.sk_pathmeasure_get_pos_tan_3 sk_pathmeasure_get_pos_tan_3 = DefaultInterop.sk_pathmeasure_get_pos_tan;


		public static SkiaApiDelegates.sk_pathmeasure_get_matrix sk_pathmeasure_get_matrix = DefaultInterop.sk_pathmeasure_get_matrix;


		public static SkiaApiDelegates.sk_pathmeasure_get_segment sk_pathmeasure_get_segment = DefaultInterop.sk_pathmeasure_get_segment;


		public static SkiaApiDelegates.sk_pathmeasure_is_closed sk_pathmeasure_is_closed = DefaultInterop.sk_pathmeasure_is_closed;


		public static SkiaApiDelegates.sk_pathmeasure_next_contour sk_pathmeasure_next_contour = DefaultInterop.sk_pathmeasure_next_contour;

		// path ops


		public static SkiaApiDelegates.sk_pathop_op sk_pathop_op = DefaultInterop.sk_pathop_op;


		public static SkiaApiDelegates.sk_pathop_simplify sk_pathop_simplify = DefaultInterop.sk_pathop_simplify;


		public static SkiaApiDelegates.sk_pathop_tight_bounds sk_pathop_tight_bounds = DefaultInterop.sk_pathop_tight_bounds;

		// path op builder

		public static SkiaApiDelegates.sk_opbuilder_new sk_opbuilder_new = DefaultInterop.sk_opbuilder_new;

		public static SkiaApiDelegates.sk_opbuilder_destroy sk_opbuilder_destroy = DefaultInterop.sk_opbuilder_destroy;

		public static SkiaApiDelegates.sk_opbuilder_add sk_opbuilder_add = DefaultInterop.sk_opbuilder_add;


		public static SkiaApiDelegates.sk_opbuilder_resolve sk_opbuilder_resolve = DefaultInterop.sk_opbuilder_resolve;

		// iterator

		public static SkiaApiDelegates.sk_path_create_iter sk_path_create_iter = DefaultInterop.sk_path_create_iter;

		public static SkiaApiDelegates.sk_path_iter_next sk_path_iter_next = DefaultInterop.sk_path_iter_next;

		public static SkiaApiDelegates.sk_path_iter_conic_weight sk_path_iter_conic_weight = DefaultInterop.sk_path_iter_conic_weight;

		public static SkiaApiDelegates.sk_path_iter_is_close_line sk_path_iter_is_close_line = DefaultInterop.sk_path_iter_is_close_line;

		public static SkiaApiDelegates.sk_path_iter_is_closed_contour sk_path_iter_is_closed_contour = DefaultInterop.sk_path_iter_is_closed_contour;

		public static SkiaApiDelegates.sk_path_iter_destroy sk_path_iter_destroy = DefaultInterop.sk_path_iter_destroy;

		// Raw iterator

		public static SkiaApiDelegates.sk_path_create_rawiter sk_path_create_rawiter = DefaultInterop.sk_path_create_rawiter;

		public static SkiaApiDelegates.sk_path_rawiter_next sk_path_rawiter_next = DefaultInterop.sk_path_rawiter_next;

		public static SkiaApiDelegates.sk_path_rawiter_peek sk_path_rawiter_peek = DefaultInterop.sk_path_rawiter_peek;

		public static SkiaApiDelegates.sk_path_rawiter_conic_weight sk_path_rawiter_conic_weight = DefaultInterop.sk_path_rawiter_conic_weight;

		public static SkiaApiDelegates.sk_path_rawiter_destroy sk_path_rawiter_destroy = DefaultInterop.sk_path_rawiter_destroy;

		// SkMaskFilter

		public static SkiaApiDelegates.sk_maskfilter_unref sk_maskfilter_unref = DefaultInterop.sk_maskfilter_unref;

		public static SkiaApiDelegates.sk_maskfilter_new_blur sk_maskfilter_new_blur = DefaultInterop.sk_maskfilter_new_blur;

		public static SkiaApiDelegates.sk_maskfilter_new_blur_with_flags sk_maskfilter_new_blur_with_flags = DefaultInterop.sk_maskfilter_new_blur_with_flags;

		public static SkiaApiDelegates.sk_maskfilter_new_table sk_maskfilter_new_table = DefaultInterop.sk_maskfilter_new_table;

		public static SkiaApiDelegates.sk_maskfilter_new_gamma sk_maskfilter_new_gamma = DefaultInterop.sk_maskfilter_new_gamma;

		public static SkiaApiDelegates.sk_maskfilter_new_clip sk_maskfilter_new_clip = DefaultInterop.sk_maskfilter_new_clip;

		// SkImageFilter::CropRect

		public static SkiaApiDelegates.sk_imagefilter_croprect_new sk_imagefilter_croprect_new = DefaultInterop.sk_imagefilter_croprect_new;

		public static SkiaApiDelegates.sk_imagefilter_croprect_new_with_rect sk_imagefilter_croprect_new_with_rect = DefaultInterop.sk_imagefilter_croprect_new_with_rect;

		public static SkiaApiDelegates.sk_imagefilter_croprect_destructor sk_imagefilter_croprect_destructor = DefaultInterop.sk_imagefilter_croprect_destructor;

		public static SkiaApiDelegates.sk_imagefilter_croprect_get_rect sk_imagefilter_croprect_get_rect = DefaultInterop.sk_imagefilter_croprect_get_rect;

		public static SkiaApiDelegates.sk_imagefilter_croprect_get_flags sk_imagefilter_croprect_get_flags = DefaultInterop.sk_imagefilter_croprect_get_flags;

		// SkImageFilter

		public static SkiaApiDelegates.sk_imagefilter_unref sk_imagefilter_unref = DefaultInterop.sk_imagefilter_unref;

		public static SkiaApiDelegates.sk_imagefilter_new_matrix sk_imagefilter_new_matrix = DefaultInterop.sk_imagefilter_new_matrix;

		public static SkiaApiDelegates.sk_imagefilter_new_alpha_threshold sk_imagefilter_new_alpha_threshold = DefaultInterop.sk_imagefilter_new_alpha_threshold;

		public static SkiaApiDelegates.sk_imagefilter_new_blur sk_imagefilter_new_blur = DefaultInterop.sk_imagefilter_new_blur;

		public static SkiaApiDelegates.sk_imagefilter_new_color_filter sk_imagefilter_new_color_filter = DefaultInterop.sk_imagefilter_new_color_filter;

		public static SkiaApiDelegates.sk_imagefilter_new_compose sk_imagefilter_new_compose = DefaultInterop.sk_imagefilter_new_compose;

		public static SkiaApiDelegates.sk_imagefilter_new_displacement_map_effect sk_imagefilter_new_displacement_map_effect = DefaultInterop.sk_imagefilter_new_displacement_map_effect;

		public static SkiaApiDelegates.sk_imagefilter_new_drop_shadow sk_imagefilter_new_drop_shadow = DefaultInterop.sk_imagefilter_new_drop_shadow;

		public static SkiaApiDelegates.sk_imagefilter_new_distant_lit_diffuse sk_imagefilter_new_distant_lit_diffuse = DefaultInterop.sk_imagefilter_new_distant_lit_diffuse;

		public static SkiaApiDelegates.sk_imagefilter_new_point_lit_diffuse sk_imagefilter_new_point_lit_diffuse = DefaultInterop.sk_imagefilter_new_point_lit_diffuse;

		public static SkiaApiDelegates.sk_imagefilter_new_spot_lit_diffuse sk_imagefilter_new_spot_lit_diffuse = DefaultInterop.sk_imagefilter_new_spot_lit_diffuse;

		public static SkiaApiDelegates.sk_imagefilter_new_distant_lit_specular sk_imagefilter_new_distant_lit_specular = DefaultInterop.sk_imagefilter_new_distant_lit_specular;

		public static SkiaApiDelegates.sk_imagefilter_new_point_lit_specular sk_imagefilter_new_point_lit_specular = DefaultInterop.sk_imagefilter_new_point_lit_specular;

		public static SkiaApiDelegates.sk_imagefilter_new_spot_lit_specular sk_imagefilter_new_spot_lit_specular = DefaultInterop.sk_imagefilter_new_spot_lit_specular;

		public static SkiaApiDelegates.sk_imagefilter_new_magnifier sk_imagefilter_new_magnifier = DefaultInterop.sk_imagefilter_new_magnifier;

		public static SkiaApiDelegates.sk_imagefilter_new_matrix_convolution sk_imagefilter_new_matrix_convolution = DefaultInterop.sk_imagefilter_new_matrix_convolution;

		public static SkiaApiDelegates.sk_imagefilter_new_merge sk_imagefilter_new_merge = DefaultInterop.sk_imagefilter_new_merge;

		public static SkiaApiDelegates.sk_imagefilter_new_dilate sk_imagefilter_new_dilate = DefaultInterop.sk_imagefilter_new_dilate;

		public static SkiaApiDelegates.sk_imagefilter_new_erode sk_imagefilter_new_erode = DefaultInterop.sk_imagefilter_new_erode;

		public static SkiaApiDelegates.sk_imagefilter_new_offset sk_imagefilter_new_offset = DefaultInterop.sk_imagefilter_new_offset;

		public static SkiaApiDelegates.sk_imagefilter_new_picture sk_imagefilter_new_picture = DefaultInterop.sk_imagefilter_new_picture;

		public static SkiaApiDelegates.sk_imagefilter_new_picture_with_croprect sk_imagefilter_new_picture_with_croprect = DefaultInterop.sk_imagefilter_new_picture_with_croprect;

		public static SkiaApiDelegates.sk_imagefilter_new_tile sk_imagefilter_new_tile = DefaultInterop.sk_imagefilter_new_tile;

		public static SkiaApiDelegates.sk_imagefilter_new_xfermode sk_imagefilter_new_xfermode = DefaultInterop.sk_imagefilter_new_xfermode;

		public static SkiaApiDelegates.sk_imagefilter_new_arithmetic sk_imagefilter_new_arithmetic = DefaultInterop.sk_imagefilter_new_arithmetic;

		public static SkiaApiDelegates.sk_imagefilter_new_image_source sk_imagefilter_new_image_source = DefaultInterop.sk_imagefilter_new_image_source;

		public static SkiaApiDelegates.sk_imagefilter_new_image_source_default sk_imagefilter_new_image_source_default = DefaultInterop.sk_imagefilter_new_image_source_default;

		public static SkiaApiDelegates.sk_imagefilter_new_paint sk_imagefilter_new_paint = DefaultInterop.sk_imagefilter_new_paint;

		// color filter

		public static SkiaApiDelegates.sk_colorfilter_unref sk_colorfilter_unref = DefaultInterop.sk_colorfilter_unref;

		public static SkiaApiDelegates.sk_colorfilter_new_mode sk_colorfilter_new_mode = DefaultInterop.sk_colorfilter_new_mode;

		public static SkiaApiDelegates.sk_colorfilter_new_lighting sk_colorfilter_new_lighting = DefaultInterop.sk_colorfilter_new_lighting;

		public static SkiaApiDelegates.sk_colorfilter_new_compose sk_colorfilter_new_compose = DefaultInterop.sk_colorfilter_new_compose;

		public static SkiaApiDelegates.sk_colorfilter_new_color_matrix sk_colorfilter_new_color_matrix = DefaultInterop.sk_colorfilter_new_color_matrix;

		public static SkiaApiDelegates.sk_colorfilter_new_luma_color sk_colorfilter_new_luma_color = DefaultInterop.sk_colorfilter_new_luma_color;

		public static SkiaApiDelegates.sk_colorfilter_new_table sk_colorfilter_new_table = DefaultInterop.sk_colorfilter_new_table;

		public static SkiaApiDelegates.sk_colorfilter_new_table_argb sk_colorfilter_new_table_argb = DefaultInterop.sk_colorfilter_new_table_argb;

		public static SkiaApiDelegates.sk_colorfilter_new_high_contrast sk_colorfilter_new_high_contrast = DefaultInterop.sk_colorfilter_new_high_contrast;

		// data

		public static SkiaApiDelegates.sk_data_new_empty sk_data_new_empty = DefaultInterop.sk_data_new_empty;

		public static SkiaApiDelegates.sk_data_new_with_copy sk_data_new_with_copy = DefaultInterop.sk_data_new_with_copy;

		public static SkiaApiDelegates.sk_data_new_with_copy_2 sk_data_new_with_copy_2 = DefaultInterop.sk_data_new_with_copy;

		public static SkiaApiDelegates.sk_data_new_subset sk_data_new_subset = DefaultInterop.sk_data_new_subset;

		public static SkiaApiDelegates.sk_data_new_from_file sk_data_new_from_file = DefaultInterop.sk_data_new_from_file;

		public static SkiaApiDelegates.sk_data_new_from_stream sk_data_new_from_stream = DefaultInterop.sk_data_new_from_stream;

		public static SkiaApiDelegates.sk_data_new_with_proc sk_data_new_with_proc = DefaultInterop.sk_data_new_with_proc;

		public static SkiaApiDelegates.sk_data_unref sk_data_unref = DefaultInterop.sk_data_unref;

		public static SkiaApiDelegates.sk_data_get_size sk_data_get_size = DefaultInterop.sk_data_get_size;

		public static SkiaApiDelegates.sk_data_get_data sk_data_get_data = DefaultInterop.sk_data_get_data;

		public static SkiaApiDelegates.sk_data_new_uninitialized sk_data_new_uninitialized = DefaultInterop.sk_data_new_uninitialized;

		// string

		public static SkiaApiDelegates.sk_string_new_empty sk_string_new_empty = DefaultInterop.sk_string_new_empty;

		public static SkiaApiDelegates.sk_string_new_with_copy sk_string_new_with_copy = DefaultInterop.sk_string_new_with_copy;

		public static SkiaApiDelegates.sk_string_destructor sk_string_destructor = DefaultInterop.sk_string_destructor;

		public static SkiaApiDelegates.sk_string_get_size sk_string_get_size = DefaultInterop.sk_string_get_size;

		public static SkiaApiDelegates.sk_string_get_c_str sk_string_get_c_str = DefaultInterop.sk_string_get_c_str;

		// picture

		public static SkiaApiDelegates.sk_picture_recorder_delete sk_picture_recorder_delete = DefaultInterop.sk_picture_recorder_delete;

		public static SkiaApiDelegates.sk_picture_recorder_new sk_picture_recorder_new = DefaultInterop.sk_picture_recorder_new;

		public static SkiaApiDelegates.sk_picture_recorder_begin_recording sk_picture_recorder_begin_recording = DefaultInterop.sk_picture_recorder_begin_recording;

		public static SkiaApiDelegates.sk_picture_recorder_end_recording sk_picture_recorder_end_recording = DefaultInterop.sk_picture_recorder_end_recording;

		public static SkiaApiDelegates.sk_picture_recorder_end_recording_as_drawable sk_picture_recorder_end_recording_as_drawable = DefaultInterop.sk_picture_recorder_end_recording_as_drawable;

		public static SkiaApiDelegates.sk_picture_get_recording_canvas sk_picture_get_recording_canvas = DefaultInterop.sk_picture_get_recording_canvas;

		public static SkiaApiDelegates.sk_picture_unref sk_picture_unref = DefaultInterop.sk_picture_unref;

		public static SkiaApiDelegates.sk_picture_get_unique_id sk_picture_get_unique_id = DefaultInterop.sk_picture_get_unique_id;

		public static SkiaApiDelegates.sk_picture_get_cull_rect sk_picture_get_cull_rect = DefaultInterop.sk_picture_get_cull_rect;

		// drawable

		public static SkiaApiDelegates.sk_manageddrawable_new sk_manageddrawable_new = DefaultInterop.sk_manageddrawable_new;

		public static SkiaApiDelegates.sk_manageddrawable_destroy sk_manageddrawable_destroy = DefaultInterop.sk_manageddrawable_destroy;

		public static SkiaApiDelegates.sk_manageddrawable_set_delegates sk_manageddrawable_set_delegates = DefaultInterop.sk_manageddrawable_set_delegates;

		public static SkiaApiDelegates.sk_drawable_get_generation_id sk_drawable_get_generation_id = DefaultInterop.sk_drawable_get_generation_id;

		public static SkiaApiDelegates.sk_drawable_get_bounds sk_drawable_get_bounds = DefaultInterop.sk_drawable_get_bounds;

		public static SkiaApiDelegates.sk_drawable_draw sk_drawable_draw = DefaultInterop.sk_drawable_draw;

		public static SkiaApiDelegates.sk_drawable_new_picture_snapshot sk_drawable_new_picture_snapshot = DefaultInterop.sk_drawable_new_picture_snapshot;

		public static SkiaApiDelegates.sk_drawable_notify_drawing_changed sk_drawable_notify_drawing_changed = DefaultInterop.sk_drawable_notify_drawing_changed;

		// shader

		public static SkiaApiDelegates.sk_shader_unref sk_shader_unref = DefaultInterop.sk_shader_unref;

		public static SkiaApiDelegates.sk_shader_new_empty sk_shader_new_empty = DefaultInterop.sk_shader_new_empty;

		public static SkiaApiDelegates.sk_shader_new_color sk_shader_new_color = DefaultInterop.sk_shader_new_color;

		public static SkiaApiDelegates.sk_shader_new_local_matrix sk_shader_new_local_matrix = DefaultInterop.sk_shader_new_local_matrix;

		public static SkiaApiDelegates.sk_shader_new_color_filter sk_shader_new_color_filter = DefaultInterop.sk_shader_new_color_filter;

		public static SkiaApiDelegates.sk_shader_new_bitmap sk_shader_new_bitmap = DefaultInterop.sk_shader_new_bitmap;

		public static SkiaApiDelegates.sk_shader_new_bitmap_2 sk_shader_new_bitmap_2 = DefaultInterop.sk_shader_new_bitmap;

		public static SkiaApiDelegates.sk_shader_new_linear_gradient sk_shader_new_linear_gradient = DefaultInterop.sk_shader_new_linear_gradient;

		public static SkiaApiDelegates.sk_shader_new_linear_gradient_2 sk_shader_new_linear_gradient_2 = DefaultInterop.sk_shader_new_linear_gradient;

		public static SkiaApiDelegates.sk_shader_new_radial_gradient sk_shader_new_radial_gradient = DefaultInterop.sk_shader_new_radial_gradient;

		public static SkiaApiDelegates.sk_shader_new_radial_gradient_2 sk_shader_new_radial_gradient_2 = DefaultInterop.sk_shader_new_radial_gradient;

		public static SkiaApiDelegates.sk_shader_new_sweep_gradient sk_shader_new_sweep_gradient = DefaultInterop.sk_shader_new_sweep_gradient;

		public static SkiaApiDelegates.sk_shader_new_sweep_gradient_2 sk_shader_new_sweep_gradient_2 = DefaultInterop.sk_shader_new_sweep_gradient;

		public static SkiaApiDelegates.sk_shader_new_two_point_conical_gradient sk_shader_new_two_point_conical_gradient = DefaultInterop.sk_shader_new_two_point_conical_gradient;

		public static SkiaApiDelegates.sk_shader_new_two_point_conical_gradient_2 sk_shader_new_two_point_conical_gradient_2 = DefaultInterop.sk_shader_new_two_point_conical_gradient;

		public static SkiaApiDelegates.sk_shader_new_linear_gradient_3 sk_shader_new_linear_gradient_3 = DefaultInterop.sk_shader_new_linear_gradient;

		public static SkiaApiDelegates.sk_shader_new_linear_gradient_4 sk_shader_new_linear_gradient_4 = DefaultInterop.sk_shader_new_linear_gradient;

		public static SkiaApiDelegates.sk_shader_new_radial_gradient_3 sk_shader_new_radial_gradient_3 = DefaultInterop.sk_shader_new_radial_gradient;

		public static SkiaApiDelegates.sk_shader_new_radial_gradient_4 sk_shader_new_radial_gradient_4 = DefaultInterop.sk_shader_new_radial_gradient;

		public static SkiaApiDelegates.sk_shader_new_sweep_gradient_3 sk_shader_new_sweep_gradient_3 = DefaultInterop.sk_shader_new_sweep_gradient;

		public static SkiaApiDelegates.sk_shader_new_sweep_gradient_4 sk_shader_new_sweep_gradient_4 = DefaultInterop.sk_shader_new_sweep_gradient;

		public static SkiaApiDelegates.sk_shader_new_two_point_conical_gradient_3 sk_shader_new_two_point_conical_gradient_3 = DefaultInterop.sk_shader_new_two_point_conical_gradient;

		public static SkiaApiDelegates.sk_shader_new_two_point_conical_gradient_4 sk_shader_new_two_point_conical_gradient_4 = DefaultInterop.sk_shader_new_two_point_conical_gradient;

		public static SkiaApiDelegates.sk_shader_new_perlin_noise_fractal_noise sk_shader_new_perlin_noise_fractal_noise = DefaultInterop.sk_shader_new_perlin_noise_fractal_noise;

		public static SkiaApiDelegates.sk_shader_new_perlin_noise_fractal_noise_2 sk_shader_new_perlin_noise_fractal_noise_2 = DefaultInterop.sk_shader_new_perlin_noise_fractal_noise;

		public static SkiaApiDelegates.sk_shader_new_perlin_noise_turbulence sk_shader_new_perlin_noise_turbulence = DefaultInterop.sk_shader_new_perlin_noise_turbulence;

		public static SkiaApiDelegates.sk_shader_new_perlin_noise_turbulence_2 sk_shader_new_perlin_noise_turbulence_2 = DefaultInterop.sk_shader_new_perlin_noise_turbulence;

		public static SkiaApiDelegates.sk_shader_new_compose sk_shader_new_compose = DefaultInterop.sk_shader_new_compose;

		public static SkiaApiDelegates.sk_shader_new_compose_with_mode sk_shader_new_compose_with_mode = DefaultInterop.sk_shader_new_compose_with_mode;

		// typeface

		public static SkiaApiDelegates.sk_typeface_create_default sk_typeface_create_default = DefaultInterop.sk_typeface_create_default;

		public static SkiaApiDelegates.sk_typeface_ref_default sk_typeface_ref_default = DefaultInterop.sk_typeface_ref_default;

		public static SkiaApiDelegates.sk_typeface_create_from_name_with_font_style sk_typeface_create_from_name_with_font_style = DefaultInterop.sk_typeface_create_from_name_with_font_style;

		public static SkiaApiDelegates.sk_typeface_create_from_file sk_typeface_create_from_file = DefaultInterop.sk_typeface_create_from_file;

		public static SkiaApiDelegates.sk_typeface_create_from_stream sk_typeface_create_from_stream = DefaultInterop.sk_typeface_create_from_stream;

		public static SkiaApiDelegates.sk_typeface_unref sk_typeface_unref = DefaultInterop.sk_typeface_unref;

		public static SkiaApiDelegates.sk_typeface_chars_to_glyphs sk_typeface_chars_to_glyphs = DefaultInterop.sk_typeface_chars_to_glyphs;

		public static SkiaApiDelegates.sk_typeface_get_family_name sk_typeface_get_family_name = DefaultInterop.sk_typeface_get_family_name;

		public static SkiaApiDelegates.sk_typeface_count_tables sk_typeface_count_tables = DefaultInterop.sk_typeface_count_tables;

		public static SkiaApiDelegates.sk_typeface_get_table_tags sk_typeface_get_table_tags = DefaultInterop.sk_typeface_get_table_tags;

		public static SkiaApiDelegates.sk_typeface_get_table_size sk_typeface_get_table_size = DefaultInterop.sk_typeface_get_table_size;

		public static SkiaApiDelegates.sk_typeface_get_table_data sk_typeface_get_table_data = DefaultInterop.sk_typeface_get_table_data;

		public static SkiaApiDelegates.sk_typeface_get_fontstyle sk_typeface_get_fontstyle = DefaultInterop.sk_typeface_get_fontstyle;

		public static SkiaApiDelegates.sk_typeface_get_font_weight sk_typeface_get_font_weight = DefaultInterop.sk_typeface_get_font_weight;

		public static SkiaApiDelegates.sk_typeface_get_font_width sk_typeface_get_font_width = DefaultInterop.sk_typeface_get_font_width;

		public static SkiaApiDelegates.sk_typeface_get_font_slant sk_typeface_get_font_slant = DefaultInterop.sk_typeface_get_font_slant;

		public static SkiaApiDelegates.sk_typeface_open_stream sk_typeface_open_stream = DefaultInterop.sk_typeface_open_stream;

		public static SkiaApiDelegates.sk_typeface_get_units_per_em sk_typeface_get_units_per_em = DefaultInterop.sk_typeface_get_units_per_em;

		// font manager

		public static SkiaApiDelegates.sk_fontmgr_create_default sk_fontmgr_create_default = DefaultInterop.sk_fontmgr_create_default;

		public static SkiaApiDelegates.sk_fontmgr_ref_default sk_fontmgr_ref_default = DefaultInterop.sk_fontmgr_ref_default;

		public static SkiaApiDelegates.sk_fontmgr_unref sk_fontmgr_unref = DefaultInterop.sk_fontmgr_unref;

		public static SkiaApiDelegates.sk_fontmgr_count_families sk_fontmgr_count_families = DefaultInterop.sk_fontmgr_count_families;

		public static SkiaApiDelegates.sk_fontmgr_get_family_name sk_fontmgr_get_family_name = DefaultInterop.sk_fontmgr_get_family_name;

		public static SkiaApiDelegates.sk_fontmgr_match_family_style_character sk_fontmgr_match_family_style_character = DefaultInterop.sk_fontmgr_match_family_style_character;

		public static SkiaApiDelegates.sk_fontmgr_create_styleset sk_fontmgr_create_styleset = DefaultInterop.sk_fontmgr_create_styleset;

		public static SkiaApiDelegates.sk_fontmgr_match_family sk_fontmgr_match_family = DefaultInterop.sk_fontmgr_match_family;

		public static SkiaApiDelegates.sk_fontmgr_match_family_style sk_fontmgr_match_family_style = DefaultInterop.sk_fontmgr_match_family_style;

		public static SkiaApiDelegates.sk_fontmgr_match_face_style sk_fontmgr_match_face_style = DefaultInterop.sk_fontmgr_match_face_style;

		public static SkiaApiDelegates.sk_fontmgr_create_from_data sk_fontmgr_create_from_data = DefaultInterop.sk_fontmgr_create_from_data;

		public static SkiaApiDelegates.sk_fontmgr_create_from_stream sk_fontmgr_create_from_stream = DefaultInterop.sk_fontmgr_create_from_stream;

		public static SkiaApiDelegates.sk_fontmgr_create_from_file sk_fontmgr_create_from_file = DefaultInterop.sk_fontmgr_create_from_file;

		// font style

		public static SkiaApiDelegates.sk_fontstyle_new sk_fontstyle_new = DefaultInterop.sk_fontstyle_new;

		public static SkiaApiDelegates.sk_fontstyle_delete sk_fontstyle_delete = DefaultInterop.sk_fontstyle_delete;

		public static SkiaApiDelegates.sk_fontstyle_get_weight sk_fontstyle_get_weight = DefaultInterop.sk_fontstyle_get_weight;

		public static SkiaApiDelegates.sk_fontstyle_get_width sk_fontstyle_get_width = DefaultInterop.sk_fontstyle_get_width;

		public static SkiaApiDelegates.sk_fontstyle_get_slant sk_fontstyle_get_slant = DefaultInterop.sk_fontstyle_get_slant;

		// font style set

		public static SkiaApiDelegates.sk_fontstyleset_create_empty sk_fontstyleset_create_empty = DefaultInterop.sk_fontstyleset_create_empty;

		public static SkiaApiDelegates.sk_fontstyleset_unref sk_fontstyleset_unref = DefaultInterop.sk_fontstyleset_unref;

		public static SkiaApiDelegates.sk_fontstyleset_get_count sk_fontstyleset_get_count = DefaultInterop.sk_fontstyleset_get_count;

		public static SkiaApiDelegates.sk_fontstyleset_get_style sk_fontstyleset_get_style = DefaultInterop.sk_fontstyleset_get_style;

		public static SkiaApiDelegates.sk_fontstyleset_create_typeface sk_fontstyleset_create_typeface = DefaultInterop.sk_fontstyleset_create_typeface;

		public static SkiaApiDelegates.sk_fontstyleset_match_style sk_fontstyleset_match_style = DefaultInterop.sk_fontstyleset_match_style;

		// streams

		public static SkiaApiDelegates.sk_memorystream_destroy sk_memorystream_destroy = DefaultInterop.sk_memorystream_destroy;

		public static SkiaApiDelegates.sk_filestream_destroy sk_filestream_destroy = DefaultInterop.sk_filestream_destroy;

		public static SkiaApiDelegates.sk_stream_asset_destroy sk_stream_asset_destroy = DefaultInterop.sk_stream_asset_destroy;

		public static SkiaApiDelegates.sk_stream_read sk_stream_read = DefaultInterop.sk_stream_read;

		public static SkiaApiDelegates.sk_stream_peek sk_stream_peek = DefaultInterop.sk_stream_peek;

		public static SkiaApiDelegates.sk_stream_skip sk_stream_skip = DefaultInterop.sk_stream_skip;


		public static SkiaApiDelegates.sk_stream_is_at_end sk_stream_is_at_end = DefaultInterop.sk_stream_is_at_end;


		public static SkiaApiDelegates.sk_stream_read_s8 sk_stream_read_s8 = DefaultInterop.sk_stream_read_s8;


		public static SkiaApiDelegates.sk_stream_read_s16 sk_stream_read_s16 = DefaultInterop.sk_stream_read_s16;


		public static SkiaApiDelegates.sk_stream_read_s32 sk_stream_read_s32 = DefaultInterop.sk_stream_read_s32;


		public static SkiaApiDelegates.sk_stream_read_u8 sk_stream_read_u8 = DefaultInterop.sk_stream_read_u8;


		public static SkiaApiDelegates.sk_stream_read_u16 sk_stream_read_u16 = DefaultInterop.sk_stream_read_u16;


		public static SkiaApiDelegates.sk_stream_read_u32 sk_stream_read_u32 = DefaultInterop.sk_stream_read_u32;


		public static SkiaApiDelegates.sk_stream_read_bool sk_stream_read_bool = DefaultInterop.sk_stream_read_bool;


		public static SkiaApiDelegates.sk_stream_rewind sk_stream_rewind = DefaultInterop.sk_stream_rewind;


		public static SkiaApiDelegates.sk_stream_has_position sk_stream_has_position = DefaultInterop.sk_stream_has_position;

		public static SkiaApiDelegates.sk_stream_get_position sk_stream_get_position = DefaultInterop.sk_stream_get_position;


		public static SkiaApiDelegates.sk_stream_seek sk_stream_seek = DefaultInterop.sk_stream_seek;


		public static SkiaApiDelegates.sk_stream_move sk_stream_move = DefaultInterop.sk_stream_move;


		public static SkiaApiDelegates.sk_stream_has_length sk_stream_has_length = DefaultInterop.sk_stream_has_length;

		public static SkiaApiDelegates.sk_stream_get_length sk_stream_get_length = DefaultInterop.sk_stream_get_length;

		public static SkiaApiDelegates.sk_stream_get_memory_base sk_stream_get_memory_base = DefaultInterop.sk_stream_get_memory_base;

		public static SkiaApiDelegates.sk_filestream_new sk_filestream_new = DefaultInterop.sk_filestream_new;

		public static SkiaApiDelegates.sk_memorystream_new sk_memorystream_new = DefaultInterop.sk_memorystream_new;

		public static SkiaApiDelegates.sk_memorystream_new_with_length sk_memorystream_new_with_length = DefaultInterop.sk_memorystream_new_with_length;

		public static SkiaApiDelegates.sk_memorystream_new_with_data sk_memorystream_new_with_data = DefaultInterop.sk_memorystream_new_with_data;

		public static SkiaApiDelegates.sk_memorystream_new_with_data_2 sk_memorystream_new_with_data_2 = DefaultInterop.sk_memorystream_new_with_data;

		public static SkiaApiDelegates.sk_memorystream_new_with_skdata sk_memorystream_new_with_skdata = DefaultInterop.sk_memorystream_new_with_skdata;

		public static SkiaApiDelegates.sk_memorystream_set_memory sk_memorystream_set_memory = DefaultInterop.sk_memorystream_set_memory;

		public static SkiaApiDelegates.sk_memorystream_set_memory_2 sk_memorystream_set_memory_2 = DefaultInterop.sk_memorystream_set_memory;


		public static SkiaApiDelegates.sk_filestream_is_valid sk_filestream_is_valid = DefaultInterop.sk_filestream_is_valid;

		// managed streams

		public static SkiaApiDelegates.sk_managedstream_new sk_managedstream_new = DefaultInterop.sk_managedstream_new;

		public static SkiaApiDelegates.sk_managedstream_set_delegates sk_managedstream_set_delegates = DefaultInterop.sk_managedstream_set_delegates;

		public static SkiaApiDelegates.sk_managedstream_destroy sk_managedstream_destroy = DefaultInterop.sk_managedstream_destroy;

		public static SkiaApiDelegates.sk_managedwstream_new sk_managedwstream_new = DefaultInterop.sk_managedwstream_new;

		public static SkiaApiDelegates.sk_managedwstream_destroy sk_managedwstream_destroy = DefaultInterop.sk_managedwstream_destroy;

		public static SkiaApiDelegates.sk_managedwstream_set_delegates sk_managedwstream_set_delegates = DefaultInterop.sk_managedwstream_set_delegates;

		// writeable streams

		public static SkiaApiDelegates.sk_filewstream_destroy sk_filewstream_destroy = DefaultInterop.sk_filewstream_destroy;

		public static SkiaApiDelegates.sk_dynamicmemorywstream_destroy sk_dynamicmemorywstream_destroy = DefaultInterop.sk_dynamicmemorywstream_destroy;

		public static SkiaApiDelegates.sk_filewstream_new sk_filewstream_new = DefaultInterop.sk_filewstream_new;

		public static SkiaApiDelegates.sk_dynamicmemorywstream_new sk_dynamicmemorywstream_new = DefaultInterop.sk_dynamicmemorywstream_new;

		public static SkiaApiDelegates.sk_dynamicmemorywstream_detach_as_stream sk_dynamicmemorywstream_detach_as_stream = DefaultInterop.sk_dynamicmemorywstream_detach_as_stream;

		public static SkiaApiDelegates.sk_dynamicmemorywstream_detach_as_data sk_dynamicmemorywstream_detach_as_data = DefaultInterop.sk_dynamicmemorywstream_detach_as_data;

		public static SkiaApiDelegates.sk_dynamicmemorywstream_copy_to sk_dynamicmemorywstream_copy_to = DefaultInterop.sk_dynamicmemorywstream_copy_to;


		public static SkiaApiDelegates.sk_dynamicmemorywstream_write_to_stream sk_dynamicmemorywstream_write_to_stream = DefaultInterop.sk_dynamicmemorywstream_write_to_stream;


		public static SkiaApiDelegates.sk_wstream_write sk_wstream_write = DefaultInterop.sk_wstream_write;


		public static SkiaApiDelegates.sk_wstream_write_2 sk_wstream_write_2 = DefaultInterop.sk_wstream_write;


		public static SkiaApiDelegates.sk_wstream_newline sk_wstream_newline = DefaultInterop.sk_wstream_newline;

		public static SkiaApiDelegates.sk_wstream_flush sk_wstream_flush = DefaultInterop.sk_wstream_flush;

		public static SkiaApiDelegates.sk_wstream_bytes_written sk_wstream_bytes_written = DefaultInterop.sk_wstream_bytes_written;


		public static SkiaApiDelegates.sk_wstream_write_8 sk_wstream_write_8 = DefaultInterop.sk_wstream_write_8;


		public static SkiaApiDelegates.sk_wstream_write_16 sk_wstream_write_16 = DefaultInterop.sk_wstream_write_16;


		public static SkiaApiDelegates.sk_wstream_write_32 sk_wstream_write_32 = DefaultInterop.sk_wstream_write_32;


		public static SkiaApiDelegates.sk_wstream_write_text sk_wstream_write_text = DefaultInterop.sk_wstream_write_text;


		public static SkiaApiDelegates.sk_wstream_write_dec_as_text sk_wstream_write_dec_as_text = DefaultInterop.sk_wstream_write_dec_as_text;


		public static SkiaApiDelegates.sk_wstream_write_bigdec_as_text sk_wstream_write_bigdec_as_text = DefaultInterop.sk_wstream_write_bigdec_as_text;


		public static SkiaApiDelegates.sk_wstream_write_hex_as_text sk_wstream_write_hex_as_text = DefaultInterop.sk_wstream_write_hex_as_text;


		public static SkiaApiDelegates.sk_wstream_write_scalar_as_text sk_wstream_write_scalar_as_text = DefaultInterop.sk_wstream_write_scalar_as_text;


		public static SkiaApiDelegates.sk_wstream_write_bool sk_wstream_write_bool = DefaultInterop.sk_wstream_write_bool;


		public static SkiaApiDelegates.sk_wstream_write_scalar sk_wstream_write_scalar = DefaultInterop.sk_wstream_write_scalar;


		public static SkiaApiDelegates.sk_wstream_write_packed_uint sk_wstream_write_packed_uint = DefaultInterop.sk_wstream_write_packed_uint;


		public static SkiaApiDelegates.sk_wstream_write_stream sk_wstream_write_stream = DefaultInterop.sk_wstream_write_stream;

		public static SkiaApiDelegates.sk_wstream_get_size_of_packed_uint sk_wstream_get_size_of_packed_uint = DefaultInterop.sk_wstream_get_size_of_packed_uint;


		public static SkiaApiDelegates.sk_filewstream_is_valid sk_filewstream_is_valid = DefaultInterop.sk_filewstream_is_valid;

		// document

		public static SkiaApiDelegates.sk_document_unref sk_document_unref = DefaultInterop.sk_document_unref;

		public static SkiaApiDelegates.sk_document_create_pdf_from_stream sk_document_create_pdf_from_stream = DefaultInterop.sk_document_create_pdf_from_stream;

		public static SkiaApiDelegates.sk_document_create_pdf_from_stream_with_metadata sk_document_create_pdf_from_stream_with_metadata = DefaultInterop.sk_document_create_pdf_from_stream_with_metadata;

		public static SkiaApiDelegates.sk_document_create_xps_from_stream sk_document_create_xps_from_stream = DefaultInterop.sk_document_create_xps_from_stream;

		public static SkiaApiDelegates.sk_document_begin_page sk_document_begin_page = DefaultInterop.sk_document_begin_page;

		public static SkiaApiDelegates.sk_document_begin_page_2 sk_document_begin_page_2 = DefaultInterop.sk_document_begin_page;

		public static SkiaApiDelegates.sk_document_end_page sk_document_end_page = DefaultInterop.sk_document_end_page;

		public static SkiaApiDelegates.sk_document_close sk_document_close = DefaultInterop.sk_document_close;

		public static SkiaApiDelegates.sk_document_abort sk_document_abort = DefaultInterop.sk_document_abort;

		// codec

		public static SkiaApiDelegates.sk_codec_min_buffered_bytes_needed sk_codec_min_buffered_bytes_needed = DefaultInterop.sk_codec_min_buffered_bytes_needed;

		public static SkiaApiDelegates.sk_codec_new_from_stream sk_codec_new_from_stream = DefaultInterop.sk_codec_new_from_stream;

		public static SkiaApiDelegates.sk_codec_new_from_data sk_codec_new_from_data = DefaultInterop.sk_codec_new_from_data;

		public static SkiaApiDelegates.sk_codec_destroy sk_codec_destroy = DefaultInterop.sk_codec_destroy;

		public static SkiaApiDelegates.sk_codec_get_info sk_codec_get_info = DefaultInterop.sk_codec_get_info;

		public static SkiaApiDelegates.sk_codec_get_origin sk_codec_get_origin = DefaultInterop.sk_codec_get_origin;

		public static SkiaApiDelegates.sk_codec_get_scaled_dimensions sk_codec_get_scaled_dimensions = DefaultInterop.sk_codec_get_scaled_dimensions;


		public static SkiaApiDelegates.sk_codec_get_valid_subset sk_codec_get_valid_subset = DefaultInterop.sk_codec_get_valid_subset;

		public static SkiaApiDelegates.sk_codec_get_encoded_format sk_codec_get_encoded_format = DefaultInterop.sk_codec_get_encoded_format;

		public static SkiaApiDelegates.sk_codec_get_pixels sk_codec_get_pixels = DefaultInterop.sk_codec_get_pixels;

		public static SkiaApiDelegates.sk_codec_start_incremental_decode sk_codec_start_incremental_decode = DefaultInterop.sk_codec_start_incremental_decode;

		public static SkiaApiDelegates.sk_codec_start_incremental_decode_2 sk_codec_start_incremental_decode_2 = DefaultInterop.sk_codec_start_incremental_decode;

		public static SkiaApiDelegates.sk_codec_incremental_decode sk_codec_incremental_decode = DefaultInterop.sk_codec_incremental_decode;

		public static SkiaApiDelegates.sk_codec_get_repetition_count sk_codec_get_repetition_count = DefaultInterop.sk_codec_get_repetition_count;

		public static SkiaApiDelegates.sk_codec_get_frame_count sk_codec_get_frame_count = DefaultInterop.sk_codec_get_frame_count;

		public static SkiaApiDelegates.sk_codec_get_frame_info sk_codec_get_frame_info = DefaultInterop.sk_codec_get_frame_info;


		public static SkiaApiDelegates.sk_codec_get_frame_info_for_index sk_codec_get_frame_info_for_index = DefaultInterop.sk_codec_get_frame_info_for_index;

		public static SkiaApiDelegates.sk_codec_start_scanline_decode sk_codec_start_scanline_decode = DefaultInterop.sk_codec_start_scanline_decode;

		public static SkiaApiDelegates.sk_codec_start_scanline_decode_2 sk_codec_start_scanline_decode_2 = DefaultInterop.sk_codec_start_scanline_decode;

		public static SkiaApiDelegates.sk_codec_get_scanlines sk_codec_get_scanlines = DefaultInterop.sk_codec_get_scanlines;


		public static SkiaApiDelegates.sk_codec_skip_scanlines sk_codec_skip_scanlines = DefaultInterop.sk_codec_skip_scanlines;

		public static SkiaApiDelegates.sk_codec_get_scanline_order sk_codec_get_scanline_order = DefaultInterop.sk_codec_get_scanline_order;

		public static SkiaApiDelegates.sk_codec_next_scanline sk_codec_next_scanline = DefaultInterop.sk_codec_next_scanline;

		public static SkiaApiDelegates.sk_codec_output_scanline sk_codec_output_scanline = DefaultInterop.sk_codec_output_scanline;

		// bitmap

		public static SkiaApiDelegates.sk_bitmap_new sk_bitmap_new = DefaultInterop.sk_bitmap_new;

		public static SkiaApiDelegates.sk_bitmap_destructor sk_bitmap_destructor = DefaultInterop.sk_bitmap_destructor;

		public static SkiaApiDelegates.sk_bitmap_get_info sk_bitmap_get_info = DefaultInterop.sk_bitmap_get_info;

		public static SkiaApiDelegates.sk_bitmap_get_pixels sk_bitmap_get_pixels = DefaultInterop.sk_bitmap_get_pixels;

		public static SkiaApiDelegates.sk_bitmap_get_pixel_colors sk_bitmap_get_pixel_colors = DefaultInterop.sk_bitmap_get_pixel_colors;

		public static SkiaApiDelegates.sk_bitmap_set_pixel_colors sk_bitmap_set_pixel_colors = DefaultInterop.sk_bitmap_set_pixel_colors;

		public static SkiaApiDelegates.sk_bitmap_reset sk_bitmap_reset = DefaultInterop.sk_bitmap_reset;

		public static SkiaApiDelegates.sk_bitmap_get_row_bytes sk_bitmap_get_row_bytes = DefaultInterop.sk_bitmap_get_row_bytes;

		public static SkiaApiDelegates.sk_bitmap_get_byte_count sk_bitmap_get_byte_count = DefaultInterop.sk_bitmap_get_byte_count;


		public static SkiaApiDelegates.sk_bitmap_is_null sk_bitmap_is_null = DefaultInterop.sk_bitmap_is_null;


		public static SkiaApiDelegates.sk_bitmap_is_immutable sk_bitmap_is_immutable = DefaultInterop.sk_bitmap_is_immutable;

		public static SkiaApiDelegates.sk_bitmap_set_immutable sk_bitmap_set_immutable = DefaultInterop.sk_bitmap_set_immutable;


		public static SkiaApiDelegates.sk_bitmap_is_volatile sk_bitmap_is_volatile = DefaultInterop.sk_bitmap_is_volatile;

		public static SkiaApiDelegates.sk_bitmap_set_volatile sk_bitmap_set_volatile = DefaultInterop.sk_bitmap_set_volatile;

		public static SkiaApiDelegates.sk_bitmap_erase sk_bitmap_erase = DefaultInterop.sk_bitmap_erase;

		public static SkiaApiDelegates.sk_bitmap_erase_rect sk_bitmap_erase_rect = DefaultInterop.sk_bitmap_erase_rect;

		public static SkiaApiDelegates.sk_bitmap_get_addr_8 sk_bitmap_get_addr_8 = DefaultInterop.sk_bitmap_get_addr_8;

		public static SkiaApiDelegates.sk_bitmap_get_addr_16 sk_bitmap_get_addr_16 = DefaultInterop.sk_bitmap_get_addr_16;

		public static SkiaApiDelegates.sk_bitmap_get_addr_32 sk_bitmap_get_addr_32 = DefaultInterop.sk_bitmap_get_addr_32;

		public static SkiaApiDelegates.sk_bitmap_get_addr sk_bitmap_get_addr = DefaultInterop.sk_bitmap_get_addr;

		public static SkiaApiDelegates.sk_bitmap_get_pixel_color sk_bitmap_get_pixel_color = DefaultInterop.sk_bitmap_get_pixel_color;

		public static SkiaApiDelegates.sk_bitmap_set_pixel_color sk_bitmap_set_pixel_color = DefaultInterop.sk_bitmap_set_pixel_color;


		public static SkiaApiDelegates.sk_bitmap_ready_to_draw sk_bitmap_ready_to_draw = DefaultInterop.sk_bitmap_ready_to_draw;


		public static SkiaApiDelegates.sk_bitmap_install_pixels sk_bitmap_install_pixels = DefaultInterop.sk_bitmap_install_pixels;


		public static SkiaApiDelegates.sk_bitmap_install_pixels_with_pixmap sk_bitmap_install_pixels_with_pixmap = DefaultInterop.sk_bitmap_install_pixels_with_pixmap;


		public static SkiaApiDelegates.sk_bitmap_install_mask_pixels sk_bitmap_install_mask_pixels = DefaultInterop.sk_bitmap_install_mask_pixels;


		public static SkiaApiDelegates.sk_bitmap_try_alloc_pixels sk_bitmap_try_alloc_pixels = DefaultInterop.sk_bitmap_try_alloc_pixels;


		public static SkiaApiDelegates.sk_bitmap_try_alloc_pixels_with_flags sk_bitmap_try_alloc_pixels_with_flags = DefaultInterop.sk_bitmap_try_alloc_pixels_with_flags;

		public static SkiaApiDelegates.sk_bitmap_set_pixels sk_bitmap_set_pixels = DefaultInterop.sk_bitmap_set_pixels;


		public static SkiaApiDelegates.sk_bitmap_peek_pixels sk_bitmap_peek_pixels = DefaultInterop.sk_bitmap_peek_pixels;


		public static SkiaApiDelegates.sk_bitmap_extract_subset sk_bitmap_extract_subset = DefaultInterop.sk_bitmap_extract_subset;


		public static SkiaApiDelegates.sk_bitmap_extract_alpha sk_bitmap_extract_alpha = DefaultInterop.sk_bitmap_extract_alpha;

		public static SkiaApiDelegates.sk_bitmap_notify_pixels_changed sk_bitmap_notify_pixels_changed = DefaultInterop.sk_bitmap_notify_pixels_changed;

		public static SkiaApiDelegates.sk_bitmap_swap sk_bitmap_swap = DefaultInterop.sk_bitmap_swap;

		// color

		public static SkiaApiDelegates.sk_color_unpremultiply sk_color_unpremultiply = DefaultInterop.sk_color_unpremultiply;

		public static SkiaApiDelegates.sk_color_premultiply sk_color_premultiply = DefaultInterop.sk_color_premultiply;

		public static SkiaApiDelegates.sk_color_unpremultiply_array sk_color_unpremultiply_array = DefaultInterop.sk_color_unpremultiply_array;

		public static SkiaApiDelegates.sk_color_premultiply_array sk_color_premultiply_array = DefaultInterop.sk_color_premultiply_array;

		public static SkiaApiDelegates.sk_color_get_bit_shift sk_color_get_bit_shift = DefaultInterop.sk_color_get_bit_shift;

		// pixmap

		public static SkiaApiDelegates.sk_pixmap_destructor sk_pixmap_destructor = DefaultInterop.sk_pixmap_destructor;

		public static SkiaApiDelegates.sk_pixmap_new sk_pixmap_new = DefaultInterop.sk_pixmap_new;

		public static SkiaApiDelegates.sk_pixmap_new_with_params sk_pixmap_new_with_params = DefaultInterop.sk_pixmap_new_with_params;

		public static SkiaApiDelegates.sk_pixmap_reset sk_pixmap_reset = DefaultInterop.sk_pixmap_reset;

		public static SkiaApiDelegates.sk_pixmap_reset_with_params sk_pixmap_reset_with_params = DefaultInterop.sk_pixmap_reset_with_params;

		public static SkiaApiDelegates.sk_pixmap_get_info sk_pixmap_get_info = DefaultInterop.sk_pixmap_get_info;

		public static SkiaApiDelegates.sk_pixmap_get_row_bytes sk_pixmap_get_row_bytes = DefaultInterop.sk_pixmap_get_row_bytes;

		public static SkiaApiDelegates.sk_pixmap_get_pixels sk_pixmap_get_pixels = DefaultInterop.sk_pixmap_get_pixels;

		public static SkiaApiDelegates.sk_pixmap_get_pixels_with_xy sk_pixmap_get_pixels_with_xy = DefaultInterop.sk_pixmap_get_pixels_with_xy;

		public static SkiaApiDelegates.sk_pixmap_get_pixel_color sk_pixmap_get_pixel_color = DefaultInterop.sk_pixmap_get_pixel_color;


		public static SkiaApiDelegates.sk_pixmap_extract_subset sk_pixmap_extract_subset = DefaultInterop.sk_pixmap_extract_subset;


		public static SkiaApiDelegates.sk_pixmap_erase_color sk_pixmap_erase_color = DefaultInterop.sk_pixmap_erase_color;


		public static SkiaApiDelegates.sk_pixmap_encode_image sk_pixmap_encode_image = DefaultInterop.sk_pixmap_encode_image;


		public static SkiaApiDelegates.sk_pixmap_read_pixels sk_pixmap_read_pixels = DefaultInterop.sk_pixmap_read_pixels;


		public static SkiaApiDelegates.sk_pixmap_scale_pixels sk_pixmap_scale_pixels = DefaultInterop.sk_pixmap_scale_pixels;

		// swizzle

		public static SkiaApiDelegates.sk_swizzle_swap_rb sk_swizzle_swap_rb = DefaultInterop.sk_swizzle_swap_rb;

		// webp encoder


		public static SkiaApiDelegates.sk_webpencoder_encode sk_webpencoder_encode = DefaultInterop.sk_webpencoder_encode;

		// jpeg encoder


		public static SkiaApiDelegates.sk_jpegencoder_encode sk_jpegencoder_encode = DefaultInterop.sk_jpegencoder_encode;

		// png encoder


		public static SkiaApiDelegates.sk_pngencoder_encode sk_pngencoder_encode = DefaultInterop.sk_pngencoder_encode;

		// mask

		public static SkiaApiDelegates.sk_mask_alloc_image sk_mask_alloc_image = DefaultInterop.sk_mask_alloc_image;

		public static SkiaApiDelegates.sk_mask_free_image sk_mask_free_image = DefaultInterop.sk_mask_free_image;


		public static SkiaApiDelegates.sk_mask_is_empty sk_mask_is_empty = DefaultInterop.sk_mask_is_empty;

		public static SkiaApiDelegates.sk_mask_compute_image_size sk_mask_compute_image_size = DefaultInterop.sk_mask_compute_image_size;

		public static SkiaApiDelegates.sk_mask_compute_total_image_size sk_mask_compute_total_image_size = DefaultInterop.sk_mask_compute_total_image_size;

		public static SkiaApiDelegates.sk_mask_get_addr_1 sk_mask_get_addr_1 = DefaultInterop.sk_mask_get_addr_1;

		public static SkiaApiDelegates.sk_mask_get_addr_8 sk_mask_get_addr_8 = DefaultInterop.sk_mask_get_addr_8;

		public static SkiaApiDelegates.sk_mask_get_addr_lcd_16 sk_mask_get_addr_lcd_16 = DefaultInterop.sk_mask_get_addr_lcd_16;

		public static SkiaApiDelegates.sk_mask_get_addr_32 sk_mask_get_addr_32 = DefaultInterop.sk_mask_get_addr_32;

		public static SkiaApiDelegates.sk_mask_get_addr sk_mask_get_addr = DefaultInterop.sk_mask_get_addr;

		// matrix


		public static SkiaApiDelegates.sk_matrix_try_invert sk_matrix_try_invert = DefaultInterop.sk_matrix_try_invert;

		public static SkiaApiDelegates.sk_matrix_concat sk_matrix_concat = DefaultInterop.sk_matrix_concat;

		public static SkiaApiDelegates.sk_matrix_pre_concat sk_matrix_pre_concat = DefaultInterop.sk_matrix_pre_concat;

		public static SkiaApiDelegates.sk_matrix_post_concat sk_matrix_post_concat = DefaultInterop.sk_matrix_post_concat;

		public static SkiaApiDelegates.sk_matrix_map_rect sk_matrix_map_rect = DefaultInterop.sk_matrix_map_rect;

		public static SkiaApiDelegates.sk_matrix_map_points sk_matrix_map_points = DefaultInterop.sk_matrix_map_points;

		public static SkiaApiDelegates.sk_matrix_map_vectors sk_matrix_map_vectors = DefaultInterop.sk_matrix_map_vectors;

		public static SkiaApiDelegates.sk_matrix_map_xy sk_matrix_map_xy = DefaultInterop.sk_matrix_map_xy;

		public static SkiaApiDelegates.sk_matrix_map_vector sk_matrix_map_vector = DefaultInterop.sk_matrix_map_vector;

		public static SkiaApiDelegates.sk_matrix_map_radius sk_matrix_map_radius = DefaultInterop.sk_matrix_map_radius;

		// 3d view

		public static SkiaApiDelegates.sk_3dview_new sk_3dview_new = DefaultInterop.sk_3dview_new;

		public static SkiaApiDelegates.sk_3dview_destroy sk_3dview_destroy = DefaultInterop.sk_3dview_destroy;

		public static SkiaApiDelegates.sk_3dview_save sk_3dview_save = DefaultInterop.sk_3dview_save;

		public static SkiaApiDelegates.sk_3dview_restore sk_3dview_restore = DefaultInterop.sk_3dview_restore;

		public static SkiaApiDelegates.sk_3dview_translate sk_3dview_translate = DefaultInterop.sk_3dview_translate;

		public static SkiaApiDelegates.sk_3dview_rotate_x_degrees sk_3dview_rotate_x_degrees = DefaultInterop.sk_3dview_rotate_x_degrees;

		public static SkiaApiDelegates.sk_3dview_rotate_y_degrees sk_3dview_rotate_y_degrees = DefaultInterop.sk_3dview_rotate_y_degrees;

		public static SkiaApiDelegates.sk_3dview_rotate_z_degrees sk_3dview_rotate_z_degrees = DefaultInterop.sk_3dview_rotate_z_degrees;

		public static SkiaApiDelegates.sk_3dview_rotate_x_radians sk_3dview_rotate_x_radians = DefaultInterop.sk_3dview_rotate_x_radians;

		public static SkiaApiDelegates.sk_3dview_rotate_y_radians sk_3dview_rotate_y_radians = DefaultInterop.sk_3dview_rotate_y_radians;

		public static SkiaApiDelegates.sk_3dview_rotate_z_radians sk_3dview_rotate_z_radians = DefaultInterop.sk_3dview_rotate_z_radians;

		public static SkiaApiDelegates.sk_3dview_get_matrix sk_3dview_get_matrix = DefaultInterop.sk_3dview_get_matrix;

		public static SkiaApiDelegates.sk_3dview_apply_to_canvas sk_3dview_apply_to_canvas = DefaultInterop.sk_3dview_apply_to_canvas;

		public static SkiaApiDelegates.sk_3dview_dot_with_normal sk_3dview_dot_with_normal = DefaultInterop.sk_3dview_dot_with_normal;

		// matrix44

		public static SkiaApiDelegates.sk_matrix44_destroy sk_matrix44_destroy = DefaultInterop.sk_matrix44_destroy;

		public static SkiaApiDelegates.sk_matrix44_new sk_matrix44_new = DefaultInterop.sk_matrix44_new;

		public static SkiaApiDelegates.sk_matrix44_new_identity sk_matrix44_new_identity = DefaultInterop.sk_matrix44_new_identity;

		public static SkiaApiDelegates.sk_matrix44_new_copy sk_matrix44_new_copy = DefaultInterop.sk_matrix44_new_copy;

		public static SkiaApiDelegates.sk_matrix44_new_concat sk_matrix44_new_concat = DefaultInterop.sk_matrix44_new_concat;

		public static SkiaApiDelegates.sk_matrix44_new_matrix sk_matrix44_new_matrix = DefaultInterop.sk_matrix44_new_matrix;


		public static SkiaApiDelegates.sk_matrix44_equals sk_matrix44_equals = DefaultInterop.sk_matrix44_equals;

		public static SkiaApiDelegates.sk_matrix44_to_matrix sk_matrix44_to_matrix = DefaultInterop.sk_matrix44_to_matrix;

		public static SkiaApiDelegates.sk_matrix44_get_type sk_matrix44_get_type = DefaultInterop.sk_matrix44_get_type;

		public static SkiaApiDelegates.sk_matrix44_set_identity sk_matrix44_set_identity = DefaultInterop.sk_matrix44_set_identity;

		public static SkiaApiDelegates.sk_matrix44_get sk_matrix44_get = DefaultInterop.sk_matrix44_get;

		public static SkiaApiDelegates.sk_matrix44_set sk_matrix44_set = DefaultInterop.sk_matrix44_set;

		public static SkiaApiDelegates.sk_matrix44_as_col_major sk_matrix44_as_col_major = DefaultInterop.sk_matrix44_as_col_major;

		public static SkiaApiDelegates.sk_matrix44_as_row_major sk_matrix44_as_row_major = DefaultInterop.sk_matrix44_as_row_major;

		public static SkiaApiDelegates.sk_matrix44_set_col_major sk_matrix44_set_col_major = DefaultInterop.sk_matrix44_set_col_major;

		public static SkiaApiDelegates.sk_matrix44_set_row_major sk_matrix44_set_row_major = DefaultInterop.sk_matrix44_set_row_major;

		public static SkiaApiDelegates.sk_matrix44_set_translate sk_matrix44_set_translate = DefaultInterop.sk_matrix44_set_translate;

		public static SkiaApiDelegates.sk_matrix44_pre_translate sk_matrix44_pre_translate = DefaultInterop.sk_matrix44_pre_translate;

		public static SkiaApiDelegates.sk_matrix44_post_translate sk_matrix44_post_translate = DefaultInterop.sk_matrix44_post_translate;

		public static SkiaApiDelegates.sk_matrix44_set_scale sk_matrix44_set_scale = DefaultInterop.sk_matrix44_set_scale;

		public static SkiaApiDelegates.sk_matrix44_pre_scale sk_matrix44_pre_scale = DefaultInterop.sk_matrix44_pre_scale;

		public static SkiaApiDelegates.sk_matrix44_post_scale sk_matrix44_post_scale = DefaultInterop.sk_matrix44_post_scale;

		public static SkiaApiDelegates.sk_matrix44_set_rotate_about_degrees sk_matrix44_set_rotate_about_degrees = DefaultInterop.sk_matrix44_set_rotate_about_degrees;

		public static SkiaApiDelegates.sk_matrix44_set_rotate_about_radians sk_matrix44_set_rotate_about_radians = DefaultInterop.sk_matrix44_set_rotate_about_radians;

		public static SkiaApiDelegates.sk_matrix44_set_rotate_about_radians_unit sk_matrix44_set_rotate_about_radians_unit = DefaultInterop.sk_matrix44_set_rotate_about_radians_unit;

		public static SkiaApiDelegates.sk_matrix44_set_concat sk_matrix44_set_concat = DefaultInterop.sk_matrix44_set_concat;

		public static SkiaApiDelegates.sk_matrix44_pre_concat sk_matrix44_pre_concat = DefaultInterop.sk_matrix44_pre_concat;

		public static SkiaApiDelegates.sk_matrix44_post_concat sk_matrix44_post_concat = DefaultInterop.sk_matrix44_post_concat;


		public static SkiaApiDelegates.sk_matrix44_invert sk_matrix44_invert = DefaultInterop.sk_matrix44_invert;

		public static SkiaApiDelegates.sk_matrix44_transpose sk_matrix44_transpose = DefaultInterop.sk_matrix44_transpose;

		public static SkiaApiDelegates.sk_matrix44_map_scalars sk_matrix44_map_scalars = DefaultInterop.sk_matrix44_map_scalars;

		public static SkiaApiDelegates.sk_matrix44_map2 sk_matrix44_map2 = DefaultInterop.sk_matrix44_map2;


		public static SkiaApiDelegates.sk_matrix44_preserves_2d_axis_alignment sk_matrix44_preserves_2d_axis_alignment = DefaultInterop.sk_matrix44_preserves_2d_axis_alignment;

		public static SkiaApiDelegates.sk_matrix44_determinant sk_matrix44_determinant = DefaultInterop.sk_matrix44_determinant;

		// path effect

		public static SkiaApiDelegates.sk_path_effect_unref sk_path_effect_unref = DefaultInterop.sk_path_effect_unref;

		public static SkiaApiDelegates.sk_path_effect_create_compose sk_path_effect_create_compose = DefaultInterop.sk_path_effect_create_compose;

		public static SkiaApiDelegates.sk_path_effect_create_sum sk_path_effect_create_sum = DefaultInterop.sk_path_effect_create_sum;

		public static SkiaApiDelegates.sk_path_effect_create_discrete sk_path_effect_create_discrete = DefaultInterop.sk_path_effect_create_discrete;

		public static SkiaApiDelegates.sk_path_effect_create_corner sk_path_effect_create_corner = DefaultInterop.sk_path_effect_create_corner;

		public static SkiaApiDelegates.sk_path_effect_create_1d_path sk_path_effect_create_1d_path = DefaultInterop.sk_path_effect_create_1d_path;

		public static SkiaApiDelegates.sk_path_effect_create_2d_line sk_path_effect_create_2d_line = DefaultInterop.sk_path_effect_create_2d_line;

		public static SkiaApiDelegates.sk_path_effect_create_2d_path sk_path_effect_create_2d_path = DefaultInterop.sk_path_effect_create_2d_path;

		public static SkiaApiDelegates.sk_path_effect_create_dash sk_path_effect_create_dash = DefaultInterop.sk_path_effect_create_dash;

		public static SkiaApiDelegates.sk_path_effect_create_trim sk_path_effect_create_trim = DefaultInterop.sk_path_effect_create_trim;

		// color table

		public static SkiaApiDelegates.sk_colortable_unref sk_colortable_unref = DefaultInterop.sk_colortable_unref;

		public static SkiaApiDelegates.sk_colortable_new sk_colortable_new = DefaultInterop.sk_colortable_new;

		public static SkiaApiDelegates.sk_colortable_count sk_colortable_count = DefaultInterop.sk_colortable_count;

		public static SkiaApiDelegates.sk_colortable_read_colors sk_colortable_read_colors = DefaultInterop.sk_colortable_read_colors;

		// GPU context

		public static SkiaApiDelegates.gr_context_make_gl gr_context_make_gl = DefaultInterop.gr_context_make_gl;

		public static SkiaApiDelegates.gr_context_unref gr_context_unref = DefaultInterop.gr_context_unref;

		public static SkiaApiDelegates.gr_context_abandon_context gr_context_abandon_context = DefaultInterop.gr_context_abandon_context;

		public static SkiaApiDelegates.gr_context_release_resources_and_abandon_context gr_context_release_resources_and_abandon_context = DefaultInterop.gr_context_release_resources_and_abandon_context;

		public static SkiaApiDelegates.gr_context_get_resource_cache_limits gr_context_get_resource_cache_limits = DefaultInterop.gr_context_get_resource_cache_limits;

		public static SkiaApiDelegates.gr_context_set_resource_cache_limits gr_context_set_resource_cache_limits = DefaultInterop.gr_context_set_resource_cache_limits;

		public static SkiaApiDelegates.gr_context_get_resource_cache_usage gr_context_get_resource_cache_usage = DefaultInterop.gr_context_get_resource_cache_usage;

		public static SkiaApiDelegates.gr_context_get_max_surface_sample_count_for_color_type gr_context_get_max_surface_sample_count_for_color_type = DefaultInterop.gr_context_get_max_surface_sample_count_for_color_type;

		public static SkiaApiDelegates.gr_context_flush gr_context_flush = DefaultInterop.gr_context_flush;

		public static SkiaApiDelegates.gr_context_reset_context gr_context_reset_context = DefaultInterop.gr_context_reset_context;

		public static SkiaApiDelegates.gr_context_get_backend gr_context_get_backend = DefaultInterop.gr_context_get_backend;

		// GL interface

		public static SkiaApiDelegates.gr_glinterface_assemble_interface gr_glinterface_assemble_interface = DefaultInterop.gr_glinterface_assemble_interface;

		public static SkiaApiDelegates.gr_glinterface_assemble_gl_interface gr_glinterface_assemble_gl_interface = DefaultInterop.gr_glinterface_assemble_gl_interface;

		public static SkiaApiDelegates.gr_glinterface_assemble_gles_interface gr_glinterface_assemble_gles_interface = DefaultInterop.gr_glinterface_assemble_gles_interface;

		public static SkiaApiDelegates.gr_glinterface_create_native_interface gr_glinterface_create_native_interface = DefaultInterop.gr_glinterface_create_native_interface;

		public static SkiaApiDelegates.gr_glinterface_unref gr_glinterface_unref = DefaultInterop.gr_glinterface_unref;


		public static SkiaApiDelegates.gr_glinterface_validate gr_glinterface_validate = DefaultInterop.gr_glinterface_validate;


		public static SkiaApiDelegates.gr_glinterface_has_extension gr_glinterface_has_extension = DefaultInterop.gr_glinterface_has_extension;

		// GPU backend texture

		public static SkiaApiDelegates.gr_backendtexture_new_gl gr_backendtexture_new_gl = DefaultInterop.gr_backendtexture_new_gl;

		public static SkiaApiDelegates.gr_backendtexture_delete gr_backendtexture_delete = DefaultInterop.gr_backendtexture_delete;


		public static SkiaApiDelegates.gr_backendtexture_is_valid gr_backendtexture_is_valid = DefaultInterop.gr_backendtexture_is_valid;

		public static SkiaApiDelegates.gr_backendtexture_get_width gr_backendtexture_get_width = DefaultInterop.gr_backendtexture_get_width;

		public static SkiaApiDelegates.gr_backendtexture_get_height gr_backendtexture_get_height = DefaultInterop.gr_backendtexture_get_height;


		public static SkiaApiDelegates.gr_backendtexture_has_mipmaps gr_backendtexture_has_mipmaps = DefaultInterop.gr_backendtexture_has_mipmaps;

		public static SkiaApiDelegates.gr_backendtexture_get_backend gr_backendtexture_get_backend = DefaultInterop.gr_backendtexture_get_backend;


		public static SkiaApiDelegates.gr_backendtexture_get_gl_textureinfo gr_backendtexture_get_gl_textureinfo = DefaultInterop.gr_backendtexture_get_gl_textureinfo;

		// GPU backend render target

		public static SkiaApiDelegates.gr_backendrendertarget_new_gl gr_backendrendertarget_new_gl = DefaultInterop.gr_backendrendertarget_new_gl;

		public static SkiaApiDelegates.gr_backendrendertarget_delete gr_backendrendertarget_delete = DefaultInterop.gr_backendrendertarget_delete;


		public static SkiaApiDelegates.gr_backendrendertarget_is_valid gr_backendrendertarget_is_valid = DefaultInterop.gr_backendrendertarget_is_valid;

		public static SkiaApiDelegates.gr_backendrendertarget_get_width gr_backendrendertarget_get_width = DefaultInterop.gr_backendrendertarget_get_width;

		public static SkiaApiDelegates.gr_backendrendertarget_get_height gr_backendrendertarget_get_height = DefaultInterop.gr_backendrendertarget_get_height;

		public static SkiaApiDelegates.gr_backendrendertarget_get_samples gr_backendrendertarget_get_samples = DefaultInterop.gr_backendrendertarget_get_samples;

		public static SkiaApiDelegates.gr_backendrendertarget_get_stencils gr_backendrendertarget_get_stencils = DefaultInterop.gr_backendrendertarget_get_stencils;

		public static SkiaApiDelegates.gr_backendrendertarget_get_backend gr_backendrendertarget_get_backend = DefaultInterop.gr_backendrendertarget_get_backend;


		public static SkiaApiDelegates.gr_backendrendertarget_get_gl_framebufferinfo gr_backendrendertarget_get_gl_framebufferinfo = DefaultInterop.gr_backendrendertarget_get_gl_framebufferinfo;

		// xml

		public static SkiaApiDelegates.sk_xmlstreamwriter_new sk_xmlstreamwriter_new = DefaultInterop.sk_xmlstreamwriter_new;

		public static SkiaApiDelegates.sk_xmlstreamwriter_delete sk_xmlstreamwriter_delete = DefaultInterop.sk_xmlstreamwriter_delete;

		// svg

		public static SkiaApiDelegates.sk_svgcanvas_create sk_svgcanvas_create = DefaultInterop.sk_svgcanvas_create;

		// region

		public static SkiaApiDelegates.sk_region_new sk_region_new = DefaultInterop.sk_region_new;

		public static SkiaApiDelegates.sk_region_new2 sk_region_new2 = DefaultInterop.sk_region_new2;


		public static SkiaApiDelegates.sk_region_contains sk_region_contains = DefaultInterop.sk_region_contains;


		public static SkiaApiDelegates.sk_region_contains2 sk_region_contains2 = DefaultInterop.sk_region_contains2;


		public static SkiaApiDelegates.sk_region_intersects sk_region_intersects = DefaultInterop.sk_region_intersects;


		public static SkiaApiDelegates.sk_region_intersects_rect sk_region_intersects_rect = DefaultInterop.sk_region_intersects_rect;


		public static SkiaApiDelegates.sk_region_set_region sk_region_set_region = DefaultInterop.sk_region_set_region;


		public static SkiaApiDelegates.sk_region_set_rect sk_region_set_rect = DefaultInterop.sk_region_set_rect;


		public static SkiaApiDelegates.sk_region_set_path sk_region_set_path = DefaultInterop.sk_region_set_path;


		public static SkiaApiDelegates.sk_region_op sk_region_op = DefaultInterop.sk_region_op;


		public static SkiaApiDelegates.sk_region_op2 sk_region_op2 = DefaultInterop.sk_region_op2;

		public static SkiaApiDelegates.sk_region_get_bounds sk_region_get_bounds = DefaultInterop.sk_region_get_bounds;

		// vertices

		public static SkiaApiDelegates.sk_vertices_unref sk_vertices_unref = DefaultInterop.sk_vertices_unref;

		public static SkiaApiDelegates.sk_vertices_make_copy sk_vertices_make_copy = DefaultInterop.sk_vertices_make_copy;

		// round rect

		public static SkiaApiDelegates.sk_rrect_new sk_rrect_new = DefaultInterop.sk_rrect_new;

		public static SkiaApiDelegates.sk_rrect_new_copy sk_rrect_new_copy = DefaultInterop.sk_rrect_new_copy;

		public static SkiaApiDelegates.sk_rrect_delete sk_rrect_delete = DefaultInterop.sk_rrect_delete;

		public static SkiaApiDelegates.sk_rrect_get_type sk_rrect_get_type = DefaultInterop.sk_rrect_get_type;

		public static SkiaApiDelegates.sk_rrect_get_rect sk_rrect_get_rect = DefaultInterop.sk_rrect_get_rect;

		public static SkiaApiDelegates.sk_rrect_get_radii sk_rrect_get_radii = DefaultInterop.sk_rrect_get_radii;

		public static SkiaApiDelegates.sk_rrect_get_width sk_rrect_get_width = DefaultInterop.sk_rrect_get_width;

		public static SkiaApiDelegates.sk_rrect_get_height sk_rrect_get_height = DefaultInterop.sk_rrect_get_height;

		public static SkiaApiDelegates.sk_rrect_set_empty sk_rrect_set_empty = DefaultInterop.sk_rrect_set_empty;

		public static SkiaApiDelegates.sk_rrect_set_rect sk_rrect_set_rect = DefaultInterop.sk_rrect_set_rect;

		public static SkiaApiDelegates.sk_rrect_set_oval sk_rrect_set_oval = DefaultInterop.sk_rrect_set_oval;

		public static SkiaApiDelegates.sk_rrect_set_rect_xy sk_rrect_set_rect_xy = DefaultInterop.sk_rrect_set_rect_xy;

		public static SkiaApiDelegates.sk_rrect_set_nine_patch sk_rrect_set_nine_patch = DefaultInterop.sk_rrect_set_nine_patch;

		public static SkiaApiDelegates.sk_rrect_set_rect_radii sk_rrect_set_rect_radii = DefaultInterop.sk_rrect_set_rect_radii;

		public static SkiaApiDelegates.sk_rrect_inset sk_rrect_inset = DefaultInterop.sk_rrect_inset;

		public static SkiaApiDelegates.sk_rrect_outset sk_rrect_outset = DefaultInterop.sk_rrect_outset;

		public static SkiaApiDelegates.sk_rrect_offset sk_rrect_offset = DefaultInterop.sk_rrect_offset;


		public static SkiaApiDelegates.sk_rrect_contains sk_rrect_contains = DefaultInterop.sk_rrect_contains;


		public static SkiaApiDelegates.sk_rrect_is_valid sk_rrect_is_valid = DefaultInterop.sk_rrect_is_valid;


		public static SkiaApiDelegates.sk_rrect_transform sk_rrect_transform = DefaultInterop.sk_rrect_transform;

		// text blob

		public static SkiaApiDelegates.sk_textblob_ref sk_textblob_ref = DefaultInterop.sk_textblob_ref;

		public static SkiaApiDelegates.sk_textblob_unref sk_textblob_unref = DefaultInterop.sk_textblob_unref;

		public static SkiaApiDelegates.sk_textblob_get_unique_id sk_textblob_get_unique_id = DefaultInterop.sk_textblob_get_unique_id;

		public static SkiaApiDelegates.sk_textblob_get_bounds sk_textblob_get_bounds = DefaultInterop.sk_textblob_get_bounds;

		// text blob builder

		public static SkiaApiDelegates.sk_textblob_builder_new sk_textblob_builder_new = DefaultInterop.sk_textblob_builder_new;

		public static SkiaApiDelegates.sk_textblob_builder_delete sk_textblob_builder_delete = DefaultInterop.sk_textblob_builder_delete;

		public static SkiaApiDelegates.sk_textblob_builder_make sk_textblob_builder_make = DefaultInterop.sk_textblob_builder_make;

		public static SkiaApiDelegates.sk_textblob_builder_alloc_run_text sk_textblob_builder_alloc_run_text = DefaultInterop.sk_textblob_builder_alloc_run_text;

		public static SkiaApiDelegates.sk_textblob_builder_alloc_run_text_pos_h sk_textblob_builder_alloc_run_text_pos_h = DefaultInterop.sk_textblob_builder_alloc_run_text_pos_h;

		public static SkiaApiDelegates.sk_textblob_builder_alloc_run_text_pos sk_textblob_builder_alloc_run_text_pos = DefaultInterop.sk_textblob_builder_alloc_run_text_pos;

	}

	internal static unsafe class DefaultInterop
	{
#if __TVOS__ && __UNIFIED__
		private const string SKIA = "@rpath/libSkiaSharp.framework/libSkiaSharp";
#elif __WATCHOS__ && __UNIFIED__
		private const string SKIA = "@rpath/libSkiaSharp.framework/libSkiaSharp";
#elif __IOS__ && __UNIFIED__
		private const string SKIA = "@rpath/libSkiaSharp.framework/libSkiaSharp";
#elif __ANDROID__
		private const string SKIA = "libSkiaSharp.so";
#elif __MACOS__
		private const string SKIA = "libSkiaSharp.dylib";
#elif __DESKTOP__
		private const string SKIA = "libSkiaSharp";
#elif WINDOWS_UWP
		private const string SKIA = "libSkiaSharp.dll";
#elif NET_STANDARD
		private const string SKIA = "libSkiaSharp";
#else
		private const string SKIA = "libSkiaSharp";
#endif

		// color space
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_colorspace_unref (sk_colorspace_t cColorSpace);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_colorspace_gamma_close_to_srgb (sk_colorspace_t cColorSpace);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_colorspace_gamma_is_linear (sk_colorspace_t cColorSpace);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_colorspace_is_srgb (sk_colorspace_t cColorSpace);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKColorSpaceType sk_colorspace_gamma_get_type (sk_colorspace_t cColorSpace);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKNamedGamma sk_colorspace_gamma_get_gamma_named (sk_colorspace_t cColorSpace);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_colorspace_equals (sk_colorspace_t src, sk_colorspace_t dst);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorspace_t sk_colorspace_new_srgb ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorspace_t sk_colorspace_new_srgb_linear ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorspace_t sk_colorspace_new_icc (voidptr_t input, size_t len);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorspace_t sk_colorspace_new_icc (byte[] input, size_t len);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorspace_t sk_colorspace_new_rgb_with_gamma (SKColorSpaceRenderTargetGamma gamma, sk_matrix44_t toXYZD50);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorspace_t sk_colorspace_new_rgb_with_gamma_and_gamut (SKColorSpaceRenderTargetGamma gamma, SKColorSpaceGamut gamut);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorspace_t sk_colorspace_new_rgb_with_coeffs (ref SKColorSpaceTransferFn coeffs, sk_matrix44_t toXYZD50);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorspace_t sk_colorspace_new_rgb_with_coeffs_and_gamut (ref SKColorSpaceTransferFn coeffs, SKColorSpaceGamut gamut);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorspace_t sk_colorspace_new_rgb_with_gamma_named (SKNamedGamma gamma, sk_matrix44_t toXYZD50);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorspace_t sk_colorspace_new_rgb_with_gamma_named_and_gamut (SKNamedGamma gamma, SKColorSpaceGamut gamut);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_colorspace_to_xyzd50 (sk_colorspace_t cColorSpace, sk_matrix44_t toXYZD50);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_matrix44_t sk_colorspace_as_to_xyzd50 (sk_colorspace_t cColorSpace);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_matrix44_t sk_colorspace_as_from_xyzd50 (sk_colorspace_t cColorSpace);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_colorspace_is_numerical_transfer_fn (sk_colorspace_t cColorSpace, out SKColorSpaceTransferFn fn);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_colorspaceprimaries_to_xyzd50 (ref SKColorSpacePrimaries primaries, sk_matrix44_t toXYZD50);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_colorspace_transfer_fn_invert (ref SKColorSpaceTransferFn transfer, out SKColorSpaceTransferFn inverted);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static float sk_colorspace_transfer_fn_transform (ref SKColorSpaceTransferFn transfer, float x);

		// color type
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKColorType sk_colortype_get_default_8888 ();

		// surface
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_surface_t sk_surface_new_null (int width, int height);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_surface_unref (sk_surface_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_surface_t sk_surface_new_raster (ref SKImageInfoNative info, size_t rowBytes, sk_surfaceprops_t props);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_surface_t sk_surface_new_raster_direct (ref SKImageInfoNative info, voidptr_t pixels, size_t rowBytes, SKSurfaceReleaseDelegateProxyDelegate releaseProc, voidptr_t context, sk_surfaceprops_t props);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_canvas_t sk_surface_get_canvas (sk_surface_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_image_t sk_surface_new_image_snapshot (sk_surface_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_surface_t sk_surface_new_backend_render_target (gr_context_t context, gr_backendrendertarget_t target, GRSurfaceOrigin origin, SKColorType colorType, sk_colorspace_t colorspace, sk_surfaceprops_t props);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_surface_t sk_surface_new_backend_texture (gr_context_t context, gr_backendtexture_t texture, GRSurfaceOrigin origin, int samples, SKColorType colorType, sk_colorspace_t colorspace, sk_surfaceprops_t props);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_surface_t sk_surface_new_backend_texture_as_render_target (gr_context_t context, gr_backendtexture_t texture, GRSurfaceOrigin origin, int samples, SKColorType colorType, sk_colorspace_t colorspace, sk_surfaceprops_t props);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_surface_t sk_surface_new_render_target (gr_context_t context, [MarshalAs (UnmanagedType.I1)] bool budgeted, ref SKImageInfoNative info, int sampleCount, GRSurfaceOrigin origin, sk_surfaceprops_t props, [MarshalAs (UnmanagedType.I1)] bool shouldCreateWithMips);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_surface_draw (sk_surface_t surface, sk_canvas_t canvas, float x, float y, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_surface_peek_pixels (sk_surface_t surface, sk_pixmap_t pixmap);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_surface_read_pixels (sk_surface_t surface, ref SKImageInfoNative dstInfo, voidptr_t dstPixels, size_t dstRowBytes, int srcX, int srcY);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_surfaceprops_t sk_surface_get_props (sk_surface_t surface);

		// surface props
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_surfaceprops_t sk_surfaceprops_new (UInt32 flags, SKPixelGeometry geometry);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_surfaceprops_delete (sk_surfaceprops_t props);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static UInt32 sk_surfaceprops_get_flags (sk_surfaceprops_t props);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKPixelGeometry sk_surfaceprops_get_pixel_geometry (sk_surfaceprops_t props);

		// canvas
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_canvas_save (sk_canvas_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_canvas_save_layer (sk_canvas_t t, ref SKRect rect, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_canvas_save_layer (sk_canvas_t t, nullptr_t rectZero, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_restore (sk_canvas_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_canvas_get_save_count (sk_canvas_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_restore_to_count (sk_canvas_t t, int saveCount);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_translate (sk_canvas_t t, float dx, float dy);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_scale (sk_canvas_t t, float sx, float sy);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_rotate_degrees (sk_canvas_t t, float degrees);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_rotate_radians (sk_canvas_t t, float radians);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_skew (sk_canvas_t t, float sx, float sy);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_concat (sk_canvas_t t, ref SKMatrix m);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_canvas_quick_reject (sk_canvas_t t, ref SKRect rect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_paint (sk_canvas_t t, sk_paint_t p);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_region (sk_canvas_t t, sk_region_t region, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_rect (sk_canvas_t t, ref SKRect rect, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_rrect (sk_canvas_t t, sk_rrect_t rect, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_round_rect (sk_canvas_t t, ref SKRect rect, float rx, float ry, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_oval (sk_canvas_t t, ref SKRect rect, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_circle (sk_canvas_t t, float cx, float cy, float radius, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_path (sk_canvas_t t, sk_path_t path, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_image (sk_canvas_t t, sk_image_t image, float x, float y, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_image_rect (sk_canvas_t t, sk_image_t image, ref SKRect src, ref SKRect dest, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_image_rect (sk_canvas_t t, sk_image_t image, nullptr_t srcZero, ref SKRect dest, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_picture (sk_canvas_t t, sk_picture_t pict, ref SKMatrix mat, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_picture (sk_canvas_t t, sk_picture_t pict, nullptr_t matZero, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_drawable (sk_canvas_t t, sk_manageddrawable_t drawable, ref SKMatrix mat);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_color (sk_canvas_t t, SKColor color, SKBlendMode mode);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_points (sk_canvas_t t, SKPointMode mode, size_t count, [In] SKPoint[] points, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_point (sk_canvas_t t, float x, float y, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_line (sk_canvas_t t, float x0, float y0, float x1, float y1, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_text (sk_canvas_t t, byte[] text, int len, float x, float y, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_pos_text (sk_canvas_t t, byte[] text, int len, [In] SKPoint[] points, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_text_on_path (sk_canvas_t t, byte[] text, int len, sk_path_t path, float hOffset, float vOffset, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_text (sk_canvas_t t, voidptr_t text, int len, float x, float y, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_pos_text (sk_canvas_t t, voidptr_t text, int len, [In] SKPoint[] points, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_text_on_path (sk_canvas_t t, voidptr_t text, int len, sk_path_t path, float hOffset, float vOffset, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_text_blob (sk_canvas_t canvas, sk_textblob_t text, float x, float y, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_bitmap (sk_canvas_t t, sk_bitmap_t bitmap, float x, float y, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_bitmap_rect (sk_canvas_t t, sk_bitmap_t bitmap, ref SKRect src, ref SKRect dest, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_bitmap_rect (sk_canvas_t t, sk_bitmap_t bitmap, nullptr_t srcZero, ref SKRect dest, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_reset_matrix (sk_canvas_t canvas);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_set_matrix (sk_canvas_t canvas, ref SKMatrix matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_get_total_matrix (sk_canvas_t canvas, ref SKMatrix matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_annotation (sk_canvas_t t, ref SKRect rect, byte[] key, sk_data_t value);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_url_annotation (sk_canvas_t t, ref SKRect rect, sk_data_t value);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_named_destination_annotation (sk_canvas_t t, ref SKPoint point, sk_data_t value);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_link_destination_annotation (sk_canvas_t t, ref SKRect rect, sk_data_t value);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_clip_rrect_with_operation (sk_canvas_t t, sk_rrect_t crect, SKClipOperation op, [MarshalAs (UnmanagedType.I1)] bool doAA);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_clip_rect_with_operation (sk_canvas_t t, ref SKRect crect, SKClipOperation op, [MarshalAs (UnmanagedType.I1)] bool doAA);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_clip_path_with_operation (sk_canvas_t t, sk_path_t cpath, SKClipOperation op, [MarshalAs (UnmanagedType.I1)] bool doAA);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_clip_region (sk_canvas_t t, sk_region_t region, SKClipOperation op);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_canvas_get_device_clip_bounds (sk_canvas_t t, out SKRectI cbounds);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_canvas_get_local_clip_bounds (sk_canvas_t t, out SKRect cbounds);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_canvas_t sk_canvas_new_from_bitmap (sk_bitmap_t bitmap);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_flush (sk_canvas_t canvas);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_bitmap_lattice (sk_canvas_t t, sk_bitmap_t bitmap, ref SKLatticeInternal lattice, ref SKRect dst, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_image_lattice (sk_canvas_t t, sk_image_t image, ref SKLatticeInternal lattice, ref SKRect dst, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_bitmap_nine (sk_canvas_t t, sk_bitmap_t bitmap, ref SKRectI center, ref SKRect dst, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_image_nine (sk_canvas_t t, sk_image_t image, ref SKRectI center, ref SKRect dst, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_destroy (sk_canvas_t canvas);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_canvas_draw_vertices (sk_canvas_t canvas, sk_vertices_t vertices, SKBlendMode mode, sk_paint_t paint);

		// no draw canvas
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_nodraw_canvas_t sk_nodraw_canvas_new (int width, int height);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_nodraw_canvas_destroy (sk_nodraw_canvas_t t);

		// n-way canvas
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_nway_canvas_t sk_nway_canvas_new (int width, int height);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_nway_canvas_destroy (sk_nway_canvas_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_nway_canvas_add_canvas (sk_nway_canvas_t t, sk_canvas_t canvas);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_nway_canvas_remove_canvas (sk_nway_canvas_t t, sk_canvas_t canvas);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_nway_canvas_remove_all (sk_nway_canvas_t t);

		// overdraw canvas
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_overdraw_canvas_t sk_overdraw_canvas_new (sk_canvas_t canvas);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_overdraw_canvas_destroy (sk_overdraw_canvas_t canvas);

		// paint
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_paint_t sk_paint_new ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_delete (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_reset (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_paint_is_antialias (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_antialias (sk_paint_t t, [MarshalAs (UnmanagedType.I1)] bool v);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_paint_is_dither (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_dither (sk_paint_t t, [MarshalAs (UnmanagedType.I1)] bool v);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_paint_is_verticaltext (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_verticaltext (sk_paint_t t, [MarshalAs (UnmanagedType.I1)] bool v);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_color_t sk_paint_get_color (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_color (sk_paint_t t, SKColor color);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKPaintStyle sk_paint_get_style (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_style (sk_paint_t t, SKPaintStyle style);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static float sk_paint_get_stroke_width (sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_stroke_width (sk_paint_t t, float width);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static float sk_paint_get_stroke_miter (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_stroke_miter (sk_paint_t t, float miter);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKStrokeCap sk_paint_get_stroke_cap (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_stroke_cap (sk_paint_t t, SKStrokeCap cap);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKStrokeJoin sk_paint_get_stroke_join (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_stroke_join (sk_paint_t t, SKStrokeJoin join);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_shader (sk_paint_t t, sk_shader_t shader);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_paint_get_shader (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_maskfilter (sk_paint_t t, sk_maskfilter_t filter);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_maskfilter_t sk_paint_get_maskfilter (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_colorfilter (sk_paint_t t, sk_colorfilter_t filter);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorfilter_t sk_paint_get_colorfilter (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_imagefilter (sk_paint_t t, sk_imagefilter_t filter);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_paint_get_imagefilter (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_blendmode (sk_paint_t t, SKBlendMode mode);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKBlendMode sk_paint_get_blendmode (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_filter_quality (sk_paint_t t, SKFilterQuality filterQuality);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKFilterQuality sk_paint_get_filter_quality (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_typeface_t sk_paint_get_typeface (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_typeface (sk_paint_t t, sk_typeface_t typeface);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static float sk_paint_get_textsize (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_textsize (sk_paint_t t, float size);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKTextAlign sk_paint_get_text_align (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_text_align (sk_paint_t t, SKTextAlign align);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKTextEncoding sk_paint_get_text_encoding (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_text_encoding (sk_paint_t t, SKTextEncoding encoding);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static float sk_paint_get_text_scale_x (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_text_scale_x (sk_paint_t t, float scale);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static float sk_paint_get_text_skew_x (sk_paint_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_text_skew_x (sk_paint_t t, float skew);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static float sk_paint_measure_text (sk_paint_t t, voidptr_t text, size_t length, ref SKRect bounds);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static float sk_paint_measure_text (sk_paint_t t, voidptr_t text, size_t length, nullptr_t boundsZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static size_t sk_paint_break_text (sk_paint_t t, voidptr_t text, size_t length, float maxWidth, out float measuredWidth);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_path_t sk_paint_get_text_path (sk_paint_t t, voidptr_t text, size_t length, float x, float y);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_path_t sk_paint_get_pos_text_path (sk_paint_t t, voidptr_t text, size_t length, [In] SKPoint[] points);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static float sk_paint_get_fontmetrics (sk_paint_t t, out SKFontMetrics fontMetrics, float scale);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static float sk_paint_get_fontmetrics (sk_paint_t t, nullptr_t fontMetricsZero, float scale);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_path_effect_t sk_paint_get_path_effect (sk_paint_t cpaint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_path_effect (sk_paint_t cpaint, sk_path_effect_t effect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_paint_is_linear_text (sk_paint_t cpaint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_linear_text (sk_paint_t cpaint, [MarshalAs (UnmanagedType.I1)] bool linearText);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_paint_is_subpixel_text (sk_paint_t cpaint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_subpixel_text (sk_paint_t cpaint, [MarshalAs (UnmanagedType.I1)] bool subpixelText);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_paint_is_lcd_render_text (sk_paint_t cpaint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_lcd_render_text (sk_paint_t cpaint, [MarshalAs (UnmanagedType.I1)] bool lcdText);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_paint_is_embedded_bitmap_text (sk_paint_t cpaint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_embedded_bitmap_text (sk_paint_t cpaint, [MarshalAs (UnmanagedType.I1)] bool useEmbeddedBitmapText);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_paint_is_autohinted (sk_paint_t cpaint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_autohinted (sk_paint_t cpaint, [MarshalAs (UnmanagedType.I1)] bool useAutohinter);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKPaintHinting sk_paint_get_hinting (sk_paint_t cpaint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_hinting (sk_paint_t cpaint, SKPaintHinting hintingLevel);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_paint_is_fake_bold_text (sk_paint_t cpaint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_fake_bold_text (sk_paint_t cpaint, [MarshalAs (UnmanagedType.I1)] bool fakeBoldText);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_paint_is_dev_kern_text (sk_paint_t cpaint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_paint_set_dev_kern_text (sk_paint_t cpaint, [MarshalAs (UnmanagedType.I1)] bool devKernText);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_paint_get_fill_path (sk_paint_t paint, sk_path_t src, sk_path_t dst, ref SKRect cullRect, float resScale);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_paint_get_fill_path (sk_paint_t paint, sk_path_t src, sk_path_t dst, nullptr_t cullRectZero, float resScale);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_paint_t sk_paint_clone (sk_paint_t cpaint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_paint_text_to_glyphs (sk_paint_t cpaint, voidptr_t text, size_t byteLength, UInt16* glyphs);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_paint_contains_text (sk_paint_t cpaint, voidptr_t text, size_t byteLength);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_paint_count_text (sk_paint_t cpaint, voidptr_t text, size_t byteLength);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_paint_get_text_widths (sk_paint_t cpaint, voidptr_t text, size_t byteLength, float* widths, SKRect* bounds);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_paint_get_text_intercepts (sk_paint_t cpaint, voidptr_t text, size_t byteLength, float x, float y, float[] bounds, float* intervals);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_paint_get_pos_text_intercepts (sk_paint_t cpaint, voidptr_t text, size_t byteLength, SKPoint[] pos, float[] bounds, float* intervals);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_paint_get_pos_text_h_intercepts (sk_paint_t cpaint, voidptr_t text, size_t byteLength, float[] xpos, float y, float[] bounds, float* intervals);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_paint_get_pos_text_blob_intercepts (sk_paint_t cpaint, sk_textblob_t blob, float[] bounds, float* intervals);


		// image
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_image_ref (sk_image_t image);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_image_unref (sk_image_t image);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_image_t sk_image_new_raster_copy (ref SKImageInfoNative info, voidptr_t pixels, size_t rowBytes);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_image_t sk_image_new_raster_copy_with_pixmap (sk_pixmap_t pixmap);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_image_t sk_image_new_raster_data (ref SKImageInfoNative info, sk_data_t pixels, size_t rowBytes);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_image_t sk_image_new_raster (sk_pixmap_t pixmap, SKImageRasterReleaseDelegateProxyDelegate releaseProc, voidptr_t context);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_image_t sk_image_new_from_bitmap (sk_bitmap_t cbitmap);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_image_t sk_image_new_from_encoded (sk_data_t encoded, ref SKRectI subset);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_image_t sk_image_new_from_encoded (sk_data_t encoded, nullptr_t subsetZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_image_t sk_image_new_from_texture (gr_context_t context, gr_backendtexture_t texture, GRSurfaceOrigin origin, SKColorType colorType, SKAlphaType alpha, sk_colorspace_t colorSpace, SKImageTextureReleaseDelegateProxyDelegate releaseProc, voidptr_t releaseContext);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_image_t sk_image_new_from_adopted_texture (gr_context_t context, gr_backendtexture_t texture, GRSurfaceOrigin origin, SKColorType colorType, SKAlphaType alpha, sk_colorspace_t colorSpace);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_image_t sk_image_new_from_picture (sk_picture_t picture, ref SKSizeI dimensions, ref SKMatrix matrix, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_image_t sk_image_new_from_picture (sk_picture_t picture, ref SKSizeI dimensions, nullptr_t matrixZero, sk_paint_t paint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_image_get_width (sk_image_t image);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_image_get_height (sk_image_t image);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static uint sk_image_get_unique_id (sk_image_t image);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKAlphaType sk_image_get_alpha_type (sk_image_t image);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKColorType sk_image_get_color_type (sk_image_t image);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorspace_t sk_image_get_colorspace (sk_image_t image);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_image_is_alpha_only (sk_image_t image);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_image_make_shader (sk_image_t image, SKShaderTileMode tileX, SKShaderTileMode tileY, ref SKMatrix localMatrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_image_make_shader (sk_image_t image, SKShaderTileMode tileX, SKShaderTileMode tileY, nullptr_t localMatrixZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_image_peek_pixels (sk_image_t image, sk_pixmap_t pixmap);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_image_is_texture_backed (sk_image_t image);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_image_is_lazy_generated (sk_image_t image);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_image_read_pixels (sk_image_t image, ref SKImageInfoNative dstInfo, voidptr_t dstPixels, size_t dstRowBytes, int srcX, int srcY, SKImageCachingHint cachingHint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_image_read_pixels_into_pixmap (sk_image_t image, sk_pixmap_t dst, int srcX, int srcY, SKImageCachingHint cachingHint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_image_scale_pixels (sk_image_t image, sk_pixmap_t dst, SKFilterQuality quality, SKImageCachingHint cachingHint);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_data_t sk_image_ref_encoded (sk_image_t image);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_data_t sk_image_encode (sk_image_t image);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_data_t sk_image_encode_specific (sk_image_t image, SKEncodedImageFormat encoder, int quality);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_image_t sk_image_make_subset (sk_image_t image, ref SKRectI subset);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_image_t sk_image_make_non_texture_image (sk_image_t image);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_image_t sk_image_make_with_filter (sk_image_t image, sk_imagefilter_t filter, ref SKRectI subset, ref SKRectI clipbounds, out SKRectI outSubset, out SKPoint outOffset);

		// path
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_path_contains (sk_path_t cpath, float x, float y);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_path_get_last_point (sk_path_t cpath, out SKPoint point);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_path_t sk_path_new ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_delete (sk_path_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_move_to (sk_path_t t, float x, float y);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_rmove_to (sk_path_t t, float dx, float dy);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_line_to (sk_path_t t, float x, float y);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_rline_to (sk_path_t t, float dx, float dy);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_quad_to (sk_path_t t, float x0, float y0, float x1, float y1);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_rquad_to (sk_path_t t, float dx0, float dy0, float dx1, float dy1);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_conic_to (sk_path_t t, float x0, float y0, float x1, float y1, float w);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_rconic_to (sk_path_t t, float dx0, float dy0, float dx1, float dy1, float w);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_cubic_to (sk_path_t t, float x0, float y0, float x1, float y1, float x2, float y2);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_rcubic_to (sk_path_t t, float dx0, float dy0, float dx1, float dy1, float dx2, float dy2);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_close (sk_path_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_rewind (sk_path_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_reset (sk_path_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_add_rect (sk_path_t t, ref SKRect rect, SKPathDirection direction);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_add_rect_start (sk_path_t t, ref SKRect rect, SKPathDirection direction, uint startIndex);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_add_rrect (sk_path_t t, sk_rrect_t rect, SKPathDirection direction);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_add_rrect_start (sk_path_t t, sk_rrect_t rect, SKPathDirection direction, uint startIndex);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_add_oval (sk_path_t t, ref SKRect rect, SKPathDirection direction);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_add_arc (sk_path_t t, ref SKRect rect, float startAngle, float sweepAngle);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_add_path_offset (sk_path_t t, sk_path_t other, float dx, float dy, SKPathAddMode mode);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_add_path_matrix (sk_path_t t, sk_path_t other, ref SKMatrix matrix, SKPathAddMode mode);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_add_path (sk_path_t t, sk_path_t other, SKPathAddMode mode);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_add_path_reverse (sk_path_t t, sk_path_t other);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_get_bounds (sk_path_t t, out SKRect rect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_compute_tight_bounds (sk_path_t t, out SKRect rect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKPathFillType sk_path_get_filltype (sk_path_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_set_filltype (sk_path_t t, SKPathFillType filltype);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_path_t sk_path_clone (sk_path_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_path_t sk_path_transform (sk_path_t t, ref SKMatrix matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_arc_to (sk_path_t t, float rx, float ry, float xAxisRotate, SKPathArcSize largeArc, SKPathDirection sweep, float x, float y);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_rarc_to (sk_path_t t, float rx, float ry, float xAxisRotate, SKPathArcSize largeArc, SKPathDirection sweep, float x, float y);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_arc_to_with_oval (sk_path_t t, ref SKRect oval, float startAngle, float sweepAngle, [MarshalAs (UnmanagedType.I1)] bool forceMoveTo);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_arc_to_with_points (sk_path_t t, float x1, float y1, float x2, float y2, float radius);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_add_rounded_rect (sk_path_t t, ref SKRect rect, float rx, float ry, SKPathDirection dir);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_add_circle (sk_path_t t, float x, float y, float radius, SKPathDirection dir);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_path_count_verbs (sk_path_t path);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_path_count_points (sk_path_t path);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_get_point (sk_path_t path, int index, out SKPoint point);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_path_get_points (sk_path_t path, [Out] SKPoint[] points, int max);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKPathConvexity sk_path_get_convexity (sk_path_t cpath);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_set_convexity (sk_path_t cpath, SKPathConvexity convexity);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_path_parse_svg_string (sk_path_t cpath, [MarshalAs (UnmanagedType.LPStr)] string str);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_to_svg_string (sk_path_t cpath, sk_string_t str);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_path_convert_conic_to_quads (ref SKPoint p0, ref SKPoint p1, ref SKPoint p2, float w, [Out] SKPoint[] pts, int pow2);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_add_poly (sk_path_t cpath, [In] SKPoint[] points, int count, [MarshalAs (UnmanagedType.I1)] bool close);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKPathSegmentMask sk_path_get_segment_masks (sk_path_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_path_is_oval (sk_path_t cpath, out SKRect bounds);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_path_is_rrect (sk_path_t cpath, sk_rrect_t bounds);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_path_is_line (sk_path_t cpath, [Out] SKPoint[] line);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_path_is_rect (sk_path_t cpath, out SKRect rect, [MarshalAs (UnmanagedType.I1)] out bool isClosed, out SKPathDirection direction);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_path_is_oval (sk_path_t cpath, nullptr_t boundsZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_path_is_line (sk_path_t cpath, nullptr_t lineZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_path_is_rect (sk_path_t cpath, nullptr_t rectZero, nullptr_t isClosedZero, nullptr_t directionZero);

		// path measure
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_pathmeasure_t sk_pathmeasure_new ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_pathmeasure_t sk_pathmeasure_new_with_path (sk_path_t path, [MarshalAs (UnmanagedType.I1)]bool forceClosed, float resScale);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_pathmeasure_destroy (sk_pathmeasure_t pathMeasure);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_pathmeasure_set_path (sk_pathmeasure_t pathMeasure, sk_path_t path, [MarshalAs (UnmanagedType.I1)] bool forceClosed);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static float sk_pathmeasure_get_length (sk_pathmeasure_t pathMeasure);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_pathmeasure_get_pos_tan (sk_pathmeasure_t pathMeasure, float distance, out SKPoint position, out SKPoint tangent);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_pathmeasure_get_pos_tan (sk_pathmeasure_t pathMeasure, float distance, nullptr_t positionZero, out SKPoint tangent);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_pathmeasure_get_pos_tan (sk_pathmeasure_t pathMeasure, float distance, out SKPoint position, nullptr_t tangentZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_pathmeasure_get_matrix (sk_pathmeasure_t pathMeasure, float distance, out SKMatrix matrix, SKPathMeasureMatrixFlags flags);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_pathmeasure_get_segment (sk_pathmeasure_t pathMeasure, float start, float stop, sk_path_t dst, [MarshalAs (UnmanagedType.I1)] bool startWithMoveTo);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_pathmeasure_is_closed (sk_pathmeasure_t pathMeasure);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_pathmeasure_next_contour (sk_pathmeasure_t pathMeasure);

		// path ops
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_pathop_op (sk_path_t one, sk_path_t two, SKPathOp op, sk_path_t result);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_pathop_simplify (sk_path_t path, sk_path_t result);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_pathop_tight_bounds (sk_path_t path, out SKRect result);

		// path op builder
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_opbuilder_t sk_opbuilder_new ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_opbuilder_destroy (sk_opbuilder_t builder);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_opbuilder_add (sk_opbuilder_t builder, sk_path_t path, SKPathOp op);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_opbuilder_resolve (sk_opbuilder_t builder, sk_path_t result);

		// iterator
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_path_iterator_t sk_path_create_iter (sk_path_t path, int forceClose);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKPathVerb sk_path_iter_next (sk_path_iterator_t iterator, [Out] SKPoint[] points, int doConsumeDegenerates, int exact);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static float sk_path_iter_conic_weight (sk_path_iterator_t iterator);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_path_iter_is_close_line (sk_path_iterator_t iterator);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_path_iter_is_closed_contour (sk_path_iterator_t iterator);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_iter_destroy (sk_path_t path);

		// Raw iterator
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_path_iterator_t sk_path_create_rawiter (sk_path_t path);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKPathVerb sk_path_rawiter_next (sk_path_iterator_t iterator, [Out] SKPoint[] points);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKPathVerb sk_path_rawiter_peek (sk_path_iterator_t iterator);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static float sk_path_rawiter_conic_weight (sk_path_iterator_t iterator);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_rawiter_destroy (sk_path_t path);

		// SkMaskFilter
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_maskfilter_unref (sk_maskfilter_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_maskfilter_t sk_maskfilter_new_blur (SKBlurStyle style, float sigma);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_maskfilter_t sk_maskfilter_new_blur_with_flags (SKBlurStyle style, float sigma, ref SKRect occluder, [MarshalAs (UnmanagedType.I1)] bool respectCTM);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_maskfilter_t sk_maskfilter_new_table (byte[] table /*[256]*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_maskfilter_t sk_maskfilter_new_gamma (float gamma);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_maskfilter_t sk_maskfilter_new_clip (byte min, byte max);

		// SkImageFilter::CropRect
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_croprect_t sk_imagefilter_croprect_new ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_croprect_t sk_imagefilter_croprect_new_with_rect (ref SKRect rect, SKCropRectFlags flags);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_imagefilter_croprect_destructor (sk_imagefilter_croprect_t cropRect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_imagefilter_croprect_get_rect (sk_imagefilter_croprect_t cropRect, out SKRect rect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKCropRectFlags sk_imagefilter_croprect_get_flags (sk_imagefilter_croprect_t cropRect);

		// SkImageFilter
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_imagefilter_unref (sk_imagefilter_t filter);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_matrix (ref SKMatrix matrix, SKFilterQuality quality, sk_imagefilter_t input /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_alpha_threshold (sk_region_t region, float innerThreshold, float outerThreshold, sk_imagefilter_t input /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_blur (float sigmaX, float sigmaY, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_color_filter (sk_colorfilter_t cf, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_compose (sk_imagefilter_t outer, sk_imagefilter_t inner);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_displacement_map_effect (SKDisplacementMapEffectChannelSelectorType xChannelSelector, SKDisplacementMapEffectChannelSelectorType yChannelSelector, float scale, sk_imagefilter_t displacement, sk_imagefilter_t color /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_drop_shadow (float dx, float dy, float sigmaX, float sigmaY, SKColor color, SKDropShadowImageFilterShadowMode shadowMode, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_distant_lit_diffuse (ref SKPoint3 direction, SKColor lightColor, float surfaceScale, float kd, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_point_lit_diffuse (ref SKPoint3 location, SKColor lightColor, float surfaceScale, float kd, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_spot_lit_diffuse (ref SKPoint3 location, ref SKPoint3 target, float specularExponent, float cutoffAngle, SKColor lightColor, float surfaceScale, float kd, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_distant_lit_specular (ref SKPoint3 direction, SKColor lightColor, float surfaceScale, float ks, float shininess, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_point_lit_specular (ref SKPoint3 location, SKColor lightColor, float surfaceScale, float ks, float shininess, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_spot_lit_specular (ref SKPoint3 location, ref SKPoint3 target, float specularExponent, float cutoffAngle, SKColor lightColor, float surfaceScale, float ks, float shininess, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_magnifier (ref SKRect src, float inset, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_matrix_convolution (ref SKSizeI kernelSize, float[] kernel, float gain, float bias, ref SKPointI kernelOffset, SKMatrixConvolutionTileMode tileMode, [MarshalAs (UnmanagedType.I1)] bool convolveAlpha, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_merge (sk_imagefilter_t[] filters, int count, sk_imagefilter_croprect_t cropRect /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_dilate (int radiusX, int radiusY, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_erode (int radiusX, int radiusY, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_offset (float dx, float dy, sk_imagefilter_t input /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_picture (sk_picture_t picture);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_picture_with_croprect (sk_picture_t picture, ref SKRect cropRect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_tile (ref SKRect src, ref SKRect dst, sk_imagefilter_t input);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_xfermode (SKBlendMode mode, sk_imagefilter_t background, sk_imagefilter_t foreground /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_arithmetic (float k1, float k2, float k3, float k4, [MarshalAs (UnmanagedType.I1)] bool enforcePMColor, sk_imagefilter_t background, sk_imagefilter_t foreground /*NULL*/, sk_imagefilter_croprect_t cropRect /*NULL*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_image_source (sk_image_t image, ref SKRect srcRect, ref SKRect dstRect, SKFilterQuality filterQuality);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_image_source_default (sk_image_t image);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_imagefilter_t sk_imagefilter_new_paint (sk_paint_t paint, sk_imagefilter_croprect_t cropRect /*NULL*/);

		// color filter
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_colorfilter_unref (sk_colorfilter_t filter);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorfilter_t sk_colorfilter_new_mode (SKColor c, SKBlendMode mode);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorfilter_t sk_colorfilter_new_lighting (SKColor mul, SKColor add);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorfilter_t sk_colorfilter_new_compose (sk_colorfilter_t outer, sk_colorfilter_t inner);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorfilter_t sk_colorfilter_new_color_matrix (float[] array/*[20]*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorfilter_t sk_colorfilter_new_luma_color ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorfilter_t sk_colorfilter_new_table (byte[] table/*[256]*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorfilter_t sk_colorfilter_new_table_argb (byte[] tableA/*[256]*/, byte[] tableR/*[256]*/, byte[] tableG/*[256]*/, byte[] tableB/*[256]*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colorfilter_t sk_colorfilter_new_high_contrast (ref SKHighContrastConfig config);

		// data
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_data_t sk_data_new_empty ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_data_t sk_data_new_with_copy (voidptr_t src, size_t length);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_data_t sk_data_new_with_copy (byte[] src, size_t length);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_data_t sk_data_new_subset (sk_data_t src, size_t offset, size_t length);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_data_t sk_data_new_from_file (byte[] utf8path);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_data_t sk_data_new_from_stream (sk_stream_t stream, size_t length);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_data_t sk_data_new_with_proc (voidptr_t ptr, size_t length, SKDataReleaseDelegateProxyDelegate proc, voidptr_t ctx);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_data_unref (sk_data_t d);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static size_t sk_data_get_size (sk_data_t d);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static voidptr_t sk_data_get_data (sk_data_t d);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_data_t sk_data_new_uninitialized (size_t size);

		// string
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_string_t sk_string_new_empty ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_string_t sk_string_new_with_copy (byte[] src, size_t length);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_string_destructor (sk_string_t skstring);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static size_t sk_string_get_size (sk_string_t skstring);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static voidptr_t sk_string_get_c_str (sk_string_t skstring);

		// picture
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_picture_recorder_delete (sk_picture_recorder_t r);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_picture_recorder_t sk_picture_recorder_new ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_canvas_t sk_picture_recorder_begin_recording (sk_picture_recorder_t r, ref SKRect rect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_picture_t sk_picture_recorder_end_recording (sk_picture_recorder_t r);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_drawable_t sk_picture_recorder_end_recording_as_drawable (sk_picture_recorder_t r);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_canvas_t sk_picture_get_recording_canvas (sk_picture_recorder_t r);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_picture_unref (sk_image_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static uint sk_picture_get_unique_id (sk_picture_t p);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_picture_get_cull_rect (sk_picture_t p, out SKRect rect);

		// drawable
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_manageddrawable_t sk_manageddrawable_new ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_manageddrawable_destroy (sk_manageddrawable_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_manageddrawable_set_delegates (voidptr_t pDraw, voidptr_t pGetBounds, voidptr_t pNewPictureSnapshot);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static uint sk_drawable_get_generation_id (sk_drawable_t d);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_drawable_get_bounds (sk_drawable_t d, out SKRect rect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_drawable_draw (sk_drawable_t d, sk_canvas_t c, ref SKMatrix matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_picture_t sk_drawable_new_picture_snapshot (sk_drawable_t d);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_drawable_notify_drawing_changed (sk_drawable_t d);

		// shader
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_shader_unref (sk_shader_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_empty ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_color (SKColor color);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_local_matrix (sk_shader_t proxy, ref SKMatrix matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_color_filter (sk_shader_t proxy, sk_colorfilter_t filter);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_bitmap (sk_bitmap_t src, SKShaderTileMode tmx, SKShaderTileMode tmy, ref SKMatrix matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_bitmap (sk_bitmap_t src, SKShaderTileMode tmx, SKShaderTileMode tmy, nullptr_t matrixZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_linear_gradient ([In] SKPoint[] points, [In] SKColor[] colors, float[] colorPos, int count, SKShaderTileMode mode, ref SKMatrix matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_linear_gradient ([In] SKPoint[] points, [In] SKColor[] colors, float[] colorPos, int count, SKShaderTileMode mode, nullptr_t matrixZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_radial_gradient (ref SKPoint center, float radius, [In] SKColor[] colors, float[] colorPos, int count, SKShaderTileMode mode, ref SKMatrix matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_radial_gradient (ref SKPoint center, float radius, [In] SKColor[] colors, float[] colorPos, int count, SKShaderTileMode mode, nullptr_t matrixZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_sweep_gradient (ref SKPoint center, [In] SKColor[] colors, float[] colorPos, int count, SKShaderTileMode mode, float startAngle, float endAngle, nullptr_t matrixZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_sweep_gradient (ref SKPoint center, [In] SKColor[] colors, float[] colorPos, int count, SKShaderTileMode mode, float startAngle, float endAngle, ref SKMatrix matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_two_point_conical_gradient (ref SKPoint start, float startRadius, ref SKPoint end, float endRadius, [In] SKColor[] colors, float[] colorPos, int count, SKShaderTileMode mode, ref SKMatrix matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_two_point_conical_gradient (ref SKPoint start, float startRadius, ref SKPoint end, float endRadius, [In] SKColor[] colors, float[] colorPos, int count, SKShaderTileMode mode, voidptr_t matrixZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_linear_gradient ([In] SKPoint[] points, [In] SKColor[] colors, nullptr_t colorPosZero, int count, SKShaderTileMode mode, ref SKMatrix matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_linear_gradient ([In] SKPoint[] points, [In] SKColor[] colors, nullptr_t colorPosZero, int count, SKShaderTileMode mode, nullptr_t matrixZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_radial_gradient (ref SKPoint center, float radius, [In] SKColor[] colors, nullptr_t colorPosZero, int count, SKShaderTileMode mode, ref SKMatrix matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_radial_gradient (ref SKPoint center, float radius, [In] SKColor[] colors, nullptr_t colorPosZero, int count, SKShaderTileMode mode, nullptr_t matrixZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_sweep_gradient (ref SKPoint center, [In] SKColor[] colors, nullptr_t colorPosZero, int count, SKShaderTileMode mode, float startAngle, float endAngle, nullptr_t matrixZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_sweep_gradient (ref SKPoint center, [In] SKColor[] colors, nullptr_t colorPosZero, int count, SKShaderTileMode mode, float startAngle, float endAngle, ref SKMatrix matrixZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_two_point_conical_gradient (ref SKPoint start, float startRadius, ref SKPoint end, float endRadius, [In] SKColor[] colors, nullptr_t colorPosZero, int count, SKShaderTileMode mode, ref SKMatrix matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_two_point_conical_gradient (ref SKPoint start, float startRadius, ref SKPoint end, float endRadius, [In] SKColor[] colors, nullptr_t colorPosZero, int count, SKShaderTileMode mode, nullptr_t matrixZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_perlin_noise_fractal_noise (float baseFrequencyX, float baseFrequencyY, int numOctaves, float seed, nullptr_t tileSizeZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_perlin_noise_fractal_noise (float baseFrequencyX, float baseFrequencyY, int numOctaves, float seed, ref SKPointI tileSize);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_perlin_noise_turbulence (float baseFrequencyX, float baseFrequencyY, int numOctaves, float seed, nullptr_t tileSizeZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_perlin_noise_turbulence (float baseFrequencyX, float baseFrequencyY, int numOctaves, float seed, ref SKPointI tileSize);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_compose (sk_shader_t shaderA, sk_shader_t shaderB);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_shader_t sk_shader_new_compose_with_mode (sk_shader_t shaderA, sk_shader_t shaderB, SKBlendMode mode);

		// typeface
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_typeface_t sk_typeface_create_default ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_typeface_t sk_typeface_ref_default ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_typeface_t sk_typeface_create_from_name_with_font_style ([MarshalAs (UnmanagedType.LPStr)] string familyName, sk_fontstyle_t style);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_typeface_t sk_typeface_create_from_file (byte[] utf8path, int index);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_typeface_t sk_typeface_create_from_stream (sk_stream_assetstream_t stream, int index);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_typeface_unref (sk_typeface_t t);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_typeface_chars_to_glyphs (sk_typeface_t t, voidptr_t chars, SKEncoding encoding, UInt16* glyphPtr, int glyphCount);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_string_t sk_typeface_get_family_name (sk_typeface_t typeface);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_typeface_count_tables (sk_typeface_t typeface);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_typeface_get_table_tags (sk_typeface_t typeface, sk_font_table_tag_t[] tags);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static size_t sk_typeface_get_table_size (sk_typeface_t typeface, sk_font_table_tag_t tag);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static voidptr_t sk_typeface_get_table_data (sk_typeface_t typeface, sk_font_table_tag_t tag, size_t offset, size_t length, byte* data);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_fontstyle_t sk_typeface_get_fontstyle (sk_typeface_t typeface);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_typeface_get_font_weight (sk_typeface_t typeface);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_typeface_get_font_width (sk_typeface_t typeface);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKFontStyleSlant sk_typeface_get_font_slant (sk_typeface_t typeface);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_stream_assetstream_t sk_typeface_open_stream (sk_typeface_t typeface, out int ttcIndex);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_typeface_get_units_per_em (sk_typeface_t typeface);

		// font manager
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_fontmgr_t sk_fontmgr_create_default ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_fontmgr_t sk_fontmgr_ref_default ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_fontmgr_unref (sk_fontmgr_t fontmgr);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_fontmgr_count_families (sk_fontmgr_t fontmgr);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_fontmgr_get_family_name (sk_fontmgr_t fontmgr, int index, sk_string_t familyName);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_typeface_t sk_fontmgr_match_family_style_character (sk_fontmgr_t fontmgr, [MarshalAs (UnmanagedType.LPStr)] string familyName, sk_fontstyle_t style, [In] [MarshalAs (UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] bcp47, int bcp47Count, int character);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_fontstyleset_t sk_fontmgr_create_styleset (sk_fontmgr_t fontmgr, int index);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_fontstyleset_t sk_fontmgr_match_family (sk_fontmgr_t fontmgr, [MarshalAs (UnmanagedType.LPStr)] string familyName);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_typeface_t sk_fontmgr_match_family_style (sk_fontmgr_t fontmgr, [MarshalAs (UnmanagedType.LPStr)] string familyName, sk_fontstyle_t style);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_typeface_t sk_fontmgr_match_face_style (sk_fontmgr_t fontmgr, sk_typeface_t face, sk_fontstyle_t style);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_typeface_t sk_fontmgr_create_from_data (sk_fontmgr_t fontmgr, sk_data_t data, int index);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_typeface_t sk_fontmgr_create_from_stream (sk_fontmgr_t fontmgr, sk_stream_assetstream_t stream, int index);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_typeface_t sk_fontmgr_create_from_file (sk_fontmgr_t fontmgr, byte[] utf8path, int index);

		// font style
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_fontstyle_t sk_fontstyle_new (int weight, int width, SKFontStyleSlant slant);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_fontstyle_delete (sk_fontstyle_t fs);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_fontstyle_get_weight (sk_fontstyle_t fs);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_fontstyle_get_width (sk_fontstyle_t fs);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKFontStyleSlant sk_fontstyle_get_slant (sk_fontstyle_t fs);

		// font style set
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_fontstyleset_t sk_fontstyleset_create_empty ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_fontstyleset_unref (sk_fontstyleset_t fss);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_fontstyleset_get_count (sk_fontstyleset_t fss);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_fontstyleset_get_style (sk_fontstyleset_t fss, int index, sk_fontstyle_t fs, sk_string_t style);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_typeface_t sk_fontstyleset_create_typeface (sk_fontstyleset_t fss, int index);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_typeface_t sk_fontstyleset_match_style (sk_fontstyleset_t fss, sk_fontstyle_t style);

		// streams
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_memorystream_destroy (sk_stream_memorystream_t stream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_filestream_destroy (sk_stream_filestream_t stream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_stream_asset_destroy (sk_stream_assetstream_t stream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static size_t sk_stream_read (sk_stream_t stream, voidptr_t buffer, size_t size);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static size_t sk_stream_peek (sk_stream_t stream, voidptr_t buffer, size_t size);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static size_t sk_stream_skip (sk_stream_t stream, size_t size);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_stream_is_at_end (sk_stream_t stream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_stream_read_s8 (sk_stream_t stream, out sbyte buffer);
		[return: MarshalAs (UnmanagedType.I1)]
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static bool sk_stream_read_s16 (sk_stream_t stream, out short buffer);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_stream_read_s32 (sk_stream_t stream, out int buffer);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_stream_read_u8 (sk_stream_t stream, out byte buffer);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_stream_read_u16 (sk_stream_t stream, out ushort buffer);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_stream_read_u32 (sk_stream_t stream, out uint buffer);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_stream_read_bool (sk_stream_t stream, [MarshalAs (UnmanagedType.I1)] out bool buffer);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_stream_rewind (sk_stream_t stream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_stream_has_position (sk_stream_t stream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static size_t sk_stream_get_position (sk_stream_t stream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_stream_seek (sk_stream_t stream, size_t position);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_stream_move (sk_stream_t stream, long offset);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_stream_has_length (sk_stream_t stream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static size_t sk_stream_get_length (sk_stream_t stream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static voidptr_t sk_stream_get_memory_base (sk_stream_t cstream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_stream_filestream_t sk_filestream_new (byte[] utf8path);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_stream_memorystream_t sk_memorystream_new ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_stream_memorystream_t sk_memorystream_new_with_length (size_t length);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_stream_memorystream_t sk_memorystream_new_with_data (voidptr_t data, size_t length, [MarshalAs (UnmanagedType.I1)] bool copyData);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_stream_memorystream_t sk_memorystream_new_with_data (byte[] data, size_t length, [MarshalAs (UnmanagedType.I1)] bool copyData);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_stream_memorystream_t sk_memorystream_new_with_skdata (voidptr_t data);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_memorystream_set_memory (sk_stream_memorystream_t s, voidptr_t data, size_t length, [MarshalAs (UnmanagedType.I1)] bool copyData);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_memorystream_set_memory (sk_stream_memorystream_t s, byte[] data, size_t length, [MarshalAs (UnmanagedType.I1)] bool copyData);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_filestream_is_valid (sk_stream_filestream_t cstream);

		// managed streams
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_stream_managedstream_t sk_managedstream_new ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_managedstream_set_delegates (voidptr_t pRead, voidptr_t pPeek, voidptr_t pIsAtEnd, voidptr_t pHasPosition, voidptr_t pHasLength, voidptr_t pRewind, voidptr_t pGetPosition, voidptr_t pSeek, voidptr_t pMove, voidptr_t pGetLength, voidptr_t pCreateNew, voidptr_t pDestroy);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_managedstream_destroy (sk_stream_managedstream_t stream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_wstream_managedstream_t sk_managedwstream_new ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_managedwstream_destroy (sk_wstream_managedstream_t stream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_managedwstream_set_delegates (voidptr_t pWrite, voidptr_t pFlush, voidptr_t pBytesWritten, voidptr_t pDestroy);

		// writeable streams
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_filewstream_destroy (sk_wstream_filestream_t cstream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_dynamicmemorywstream_destroy (sk_wstream_dynamicmemorystream_t cstream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_wstream_filestream_t sk_filewstream_new (byte[] utf8path);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_wstream_dynamicmemorystream_t sk_dynamicmemorywstream_new ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_stream_assetstream_t sk_dynamicmemorywstream_detach_as_stream (sk_wstream_dynamicmemorystream_t cstream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_data_t sk_dynamicmemorywstream_detach_as_data (sk_wstream_dynamicmemorystream_t cstream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_dynamicmemorywstream_copy_to (sk_wstream_dynamicmemorystream_t cstream, voidptr_t data);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_dynamicmemorywstream_write_to_stream (sk_wstream_dynamicmemorystream_t cstream, sk_wstream_t dst);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_wstream_write (sk_wstream_t cstream, voidptr_t buffer, size_t size);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_wstream_write (sk_wstream_t cstream, byte[] buffer, size_t size);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_wstream_newline (sk_wstream_t cstream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_wstream_flush (sk_wstream_t cstream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static size_t sk_wstream_bytes_written (sk_wstream_t cstream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_wstream_write_8 (sk_wstream_t cstream, byte value);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_wstream_write_16 (sk_wstream_t cstream, ushort value);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_wstream_write_32 (sk_wstream_t cstream, uint value);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_wstream_write_text (sk_wstream_t cstream, [MarshalAs (UnmanagedType.LPStr)] string value);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_wstream_write_dec_as_text (sk_wstream_t cstream, int value);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_wstream_write_bigdec_as_text (sk_wstream_t cstream, long value, int minDigits);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_wstream_write_hex_as_text (sk_wstream_t cstream, uint value, int minDigits);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_wstream_write_scalar_as_text (sk_wstream_t cstream, float value);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_wstream_write_bool (sk_wstream_t cstream, [MarshalAs (UnmanagedType.I1)] bool value);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_wstream_write_scalar (sk_wstream_t cstream, float value);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_wstream_write_packed_uint (sk_wstream_t cstream, size_t value);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_wstream_write_stream (sk_wstream_t cstream, sk_stream_t input, size_t length);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_wstream_get_size_of_packed_uint (size_t value);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_filewstream_is_valid (sk_wstream_filestream_t cstream);

		// document
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_document_unref (sk_document_t document);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_document_t sk_document_create_pdf_from_stream (sk_wstream_t stream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_document_t sk_document_create_pdf_from_stream_with_metadata (sk_wstream_t stream, ref SKDocumentPdfMetadataInternal metadata);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_document_t sk_document_create_xps_from_stream (sk_wstream_t stream, float dpi);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_canvas_t sk_document_begin_page (sk_document_t document, float width, float height, ref SKRect content);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_canvas_t sk_document_begin_page (sk_document_t document, float width, float height, nullptr_t contentZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_document_end_page (sk_document_t document);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_document_close (sk_document_t document);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_document_abort (sk_document_t document);

		// codec
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static size_t sk_codec_min_buffered_bytes_needed ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_codec_t sk_codec_new_from_stream (sk_stream_t stream, out SKCodecResult result);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_codec_t sk_codec_new_from_data (sk_data_t data);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_codec_destroy (sk_codec_t codec);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_codec_get_info (sk_codec_t codec, out SKImageInfoNative info);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKEncodedOrigin sk_codec_get_origin (sk_codec_t codec);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_codec_get_scaled_dimensions (sk_codec_t codec, float desiredScale, out SKSizeI dimensions);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_codec_get_valid_subset (sk_codec_t codec, ref SKRectI desiredSubset);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKEncodedImageFormat sk_codec_get_encoded_format (sk_codec_t codec);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKCodecResult sk_codec_get_pixels (sk_codec_t codec, ref SKImageInfoNative info, voidptr_t pixels, size_t rowBytes, ref SKCodecOptionsInternal options);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKCodecResult sk_codec_start_incremental_decode (sk_codec_t codec, ref SKImageInfoNative info, voidptr_t pixels, size_t rowBytes, ref SKCodecOptionsInternal options);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKCodecResult sk_codec_start_incremental_decode (sk_codec_t codec, ref SKImageInfoNative info, voidptr_t pixels, size_t rowBytes, nullptr_t optionsZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKCodecResult sk_codec_incremental_decode (sk_codec_t codec, out int rowsDecoded);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_codec_get_repetition_count (sk_codec_t codec);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_codec_get_frame_count (sk_codec_t codec);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_codec_get_frame_info (sk_codec_t codec, [Out] SKCodecFrameInfo[] frameInfo);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_codec_get_frame_info_for_index (sk_codec_t codec, int index, out SKCodecFrameInfo frameInfo);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKCodecResult sk_codec_start_scanline_decode (sk_codec_t codec, ref SKImageInfoNative info, ref SKCodecOptionsInternal options);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKCodecResult sk_codec_start_scanline_decode (sk_codec_t codec, ref SKImageInfoNative info, nullptr_t optionsZero);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_codec_get_scanlines (sk_codec_t codec, voidptr_t dst, int countLines, size_t rowBytes);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_codec_skip_scanlines (sk_codec_t codec, int countLines);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKCodecScanlineOrder sk_codec_get_scanline_order (sk_codec_t codec);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_codec_next_scanline (sk_codec_t codec);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_codec_output_scanline (sk_codec_t codec, int inputScanline);

		// bitmap
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_bitmap_t sk_bitmap_new ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_bitmap_destructor (sk_bitmap_t b);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_bitmap_get_info (sk_bitmap_t b, out SKImageInfoNative info);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static voidptr_t sk_bitmap_get_pixels (sk_bitmap_t b, out size_t length);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_bitmap_get_pixel_colors (sk_bitmap_t b, [Out] SKColor[] colors);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_bitmap_set_pixel_colors (sk_bitmap_t b, [In] SKColor[] colors);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_bitmap_reset (sk_bitmap_t b);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static size_t sk_bitmap_get_row_bytes (sk_bitmap_t b);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static size_t sk_bitmap_get_byte_count (sk_bitmap_t b);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_bitmap_is_null (sk_bitmap_t b);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_bitmap_is_immutable (sk_bitmap_t b);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_bitmap_set_immutable (sk_bitmap_t b);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_bitmap_is_volatile (sk_bitmap_t b);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_bitmap_set_volatile (sk_bitmap_t b, [MarshalAs (UnmanagedType.I1)] bool value);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_bitmap_erase (sk_bitmap_t cbitmap, SKColor color);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_bitmap_erase_rect (sk_bitmap_t cbitmap, SKColor color, ref SKRectI rect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static byte sk_bitmap_get_addr_8 (sk_bitmap_t cbitmap, int x, int y);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static ushort sk_bitmap_get_addr_16 (sk_bitmap_t cbitmap, int x, int y);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static uint sk_bitmap_get_addr_32 (sk_bitmap_t cbitmap, int x, int y);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static voidptr_t sk_bitmap_get_addr (sk_bitmap_t cbitmap, int x, int y);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_color_t sk_bitmap_get_pixel_color (sk_bitmap_t cbitmap, int x, int y);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_bitmap_set_pixel_color (sk_bitmap_t cbitmap, int x, int y, SKColor color);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_bitmap_ready_to_draw (sk_bitmap_t b);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_bitmap_install_pixels (sk_bitmap_t cbitmap, ref SKImageInfoNative cinfo, voidptr_t pixels, size_t rowBytes, SKBitmapReleaseDelegateProxyDelegate releaseProc, voidptr_t context);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_bitmap_install_pixels_with_pixmap (sk_bitmap_t cbitmap, sk_pixmap_t cpixmap);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_bitmap_install_mask_pixels (sk_bitmap_t cbitmap, ref SKMask cmask);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_bitmap_try_alloc_pixels (sk_bitmap_t cbitmap, ref SKImageInfoNative requestedInfo, size_t rowBytes);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_bitmap_try_alloc_pixels_with_flags (sk_bitmap_t cbitmap, ref SKImageInfoNative requestedInfo, SKBitmapAllocFlags flags);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_bitmap_set_pixels (sk_bitmap_t cbitmap, voidptr_t pixels);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_bitmap_peek_pixels (sk_bitmap_t cbitmap, sk_pixmap_t cpixmap);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_bitmap_extract_subset (sk_bitmap_t cbitmap, sk_bitmap_t cdst, ref SKRectI subset);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_bitmap_extract_alpha (sk_bitmap_t cbitmap, sk_bitmap_t dst, sk_paint_t paint, out SKPointI offset);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_bitmap_notify_pixels_changed (sk_bitmap_t cbitmap);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_bitmap_swap (sk_bitmap_t cbitmap, sk_bitmap_t cother);

		// color
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_color_t sk_color_unpremultiply (SKPMColor pmcolor);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_pmcolor_t sk_color_premultiply (SKColor color);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_color_unpremultiply_array (SKPMColor[] pmcolors, int size, [Out] SKColor[] colors);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_pmcolor_t sk_color_premultiply_array (SKColor[] colors, int size, [Out] SKPMColor[] pmcolors);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_color_get_bit_shift (out int a, out int r, out int g, out int b);

		// pixmap
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_pixmap_destructor (sk_pixmap_t cpixmap);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_pixmap_t sk_pixmap_new ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_pixmap_t sk_pixmap_new_with_params (ref SKImageInfoNative cinfo, voidptr_t addr, size_t rowBytes);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_pixmap_reset (sk_pixmap_t cpixmap);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_pixmap_reset_with_params (sk_pixmap_t cpixmap, ref SKImageInfoNative cinfo, voidptr_t addr, size_t rowBytes);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_pixmap_get_info (sk_pixmap_t cpixmap, out SKImageInfoNative cinfo);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static size_t sk_pixmap_get_row_bytes (sk_pixmap_t cpixmap);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static voidptr_t sk_pixmap_get_pixels (sk_pixmap_t cpixmap);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static voidptr_t sk_pixmap_get_pixels_with_xy (sk_pixmap_t cpixmap, int x, int y);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_color_t sk_pixmap_get_pixel_color (sk_pixmap_t t, int x, int y);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_pixmap_extract_subset (sk_pixmap_t cpixmap, sk_pixmap_t result, ref SKRectI subset);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_pixmap_erase_color (sk_pixmap_t cpixmap, SKColor color, ref SKRectI subset);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_pixmap_encode_image (sk_wstream_t dst, sk_pixmap_t src, SKEncodedImageFormat encoder, int quality);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_pixmap_read_pixels (sk_pixmap_t cpixmap, ref SKImageInfoNative dstInfo, voidptr_t dstPixels, size_t dstRowBytes, int srcX, int srcY, SKTransferFunctionBehavior behavior);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_pixmap_scale_pixels (sk_pixmap_t cpixmap, sk_pixmap_t dst, SKFilterQuality quality);

		// swizzle
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_swizzle_swap_rb (voidptr_t dest, voidptr_t src, int count);

		// webp encoder
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_webpencoder_encode (sk_wstream_t dst, sk_pixmap_t src, SKWebpEncoderOptions options);

		// jpeg encoder
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_jpegencoder_encode (sk_wstream_t dst, sk_pixmap_t src, SKJpegEncoderOptions options);

		// png encoder
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_pngencoder_encode (sk_wstream_t dst, sk_pixmap_t src, SKPngEncoderOptions options);

		// mask
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static voidptr_t sk_mask_alloc_image (size_t bytes);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_mask_free_image (voidptr_t image);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_mask_is_empty (ref SKMask cmask);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static size_t sk_mask_compute_image_size (ref SKMask cmask);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static size_t sk_mask_compute_total_image_size (ref SKMask cmask);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static byte sk_mask_get_addr_1 (ref SKMask cmask, int x, int y);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static byte sk_mask_get_addr_8 (ref SKMask cmask, int x, int y);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static UInt16 sk_mask_get_addr_lcd_16 (ref SKMask cmask, int x, int y);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static UInt32 sk_mask_get_addr_32 (ref SKMask cmask, int x, int y);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static voidptr_t sk_mask_get_addr (ref SKMask cmask, int x, int y);

		// matrix
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_matrix_try_invert (ref SKMatrix matrix, out SKMatrix result);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix_concat (ref SKMatrix target, ref SKMatrix first, ref SKMatrix second);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix_pre_concat (ref SKMatrix target, ref SKMatrix matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix_post_concat (ref SKMatrix target, ref SKMatrix matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix_map_rect (ref SKMatrix matrix, out SKRect dest, ref SKRect source);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix_map_points (ref SKMatrix matrix, voidptr_t dst, voidptr_t src, int count);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix_map_vectors (ref SKMatrix matrix, voidptr_t dst, voidptr_t src, int count);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix_map_xy (ref SKMatrix matrix, float x, float y, out SKPoint result);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix_map_vector (ref SKMatrix matrix, float x, float y, out SKPoint result);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static float sk_matrix_map_radius (ref SKMatrix matrix, float radius);

		// 3d view
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_3dview_t sk_3dview_new ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_3dview_destroy (sk_3dview_t cview);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_3dview_save (sk_3dview_t cview);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_3dview_restore (sk_3dview_t cview);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_3dview_translate (sk_3dview_t cview, float x, float y, float z);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_3dview_rotate_x_degrees (sk_3dview_t cview, float degrees);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_3dview_rotate_y_degrees (sk_3dview_t cview, float degrees);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_3dview_rotate_z_degrees (sk_3dview_t cview, float degrees);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_3dview_rotate_x_radians (sk_3dview_t cview, float radians);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_3dview_rotate_y_radians (sk_3dview_t cview, float radians);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_3dview_rotate_z_radians (sk_3dview_t cview, float radians);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_3dview_get_matrix (sk_3dview_t cview, ref SKMatrix cmatrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_3dview_apply_to_canvas (sk_3dview_t cview, sk_canvas_t ccanvas);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static float sk_3dview_dot_with_normal (sk_3dview_t cview, float dx, float dy, float dz);

		// matrix44
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_destroy (sk_matrix44_t matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_matrix44_t sk_matrix44_new ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_matrix44_t sk_matrix44_new_identity ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_matrix44_t sk_matrix44_new_copy (sk_matrix44_t src);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_matrix44_t sk_matrix44_new_concat (sk_matrix44_t a, sk_matrix44_t b);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_matrix44_t sk_matrix44_new_matrix (ref SKMatrix src);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_matrix44_equals (sk_matrix44_t matrix, sk_matrix44_t other);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_to_matrix (sk_matrix44_t matrix, out SKMatrix dst);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKMatrix44TypeMask sk_matrix44_get_type (sk_matrix44_t matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_set_identity (sk_matrix44_t matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static float sk_matrix44_get (sk_matrix44_t matrix, int row, int col);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_set (sk_matrix44_t matrix, int row, int col, float value);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_as_col_major (sk_matrix44_t matrix, [Out] float[] dst);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_as_row_major (sk_matrix44_t matrix, [Out] float[] dst);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_set_col_major (sk_matrix44_t matrix, [In] float[] src);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_set_row_major (sk_matrix44_t matrix, [In] float[] src);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_set_translate (sk_matrix44_t matrix, float dx, float dy, float dz);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_pre_translate (sk_matrix44_t matrix, float dx, float dy, float dz);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_post_translate (sk_matrix44_t matrix, float dx, float dy, float dz);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_set_scale (sk_matrix44_t matrix, float sx, float sy, float sz);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_pre_scale (sk_matrix44_t matrix, float sx, float sy, float sz);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_post_scale (sk_matrix44_t matrix, float sx, float sy, float sz);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_set_rotate_about_degrees (sk_matrix44_t matrix, float x, float y, float z, float degrees);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_set_rotate_about_radians (sk_matrix44_t matrix, float x, float y, float z, float radians);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_set_rotate_about_radians_unit (sk_matrix44_t matrix, float x, float y, float z, float radians);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_set_concat (sk_matrix44_t matrix, sk_matrix44_t a, sk_matrix44_t b);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_pre_concat (sk_matrix44_t matrix, sk_matrix44_t m);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_post_concat (sk_matrix44_t matrix, sk_matrix44_t m);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_matrix44_invert (sk_matrix44_t matrix, sk_matrix44_t inverse);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_transpose (sk_matrix44_t matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_map_scalars (sk_matrix44_t matrix, [In] float[] src, float[] dst);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_matrix44_map2 (sk_matrix44_t matrix, [In] float[] src2, int count, float[] dst);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_matrix44_preserves_2d_axis_alignment (sk_matrix44_t matrix, float epsilon);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static double sk_matrix44_determinant (sk_matrix44_t matrix);

		// path effect
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_path_effect_unref (sk_path_effect_t effect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_path_effect_t sk_path_effect_create_compose (sk_path_effect_t outer, sk_path_effect_t inner);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_path_effect_t sk_path_effect_create_sum (sk_path_effect_t first, sk_path_effect_t second);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_path_effect_t sk_path_effect_create_discrete (float segLength, float deviation, UInt32 seedAssist /*0*/);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_path_effect_t sk_path_effect_create_corner (float radius);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_path_effect_t sk_path_effect_create_1d_path (sk_path_t path, float advance, float phase, SKPath1DPathEffectStyle style);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_path_effect_t sk_path_effect_create_2d_line (float width, ref SKMatrix matrix);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_path_effect_t sk_path_effect_create_2d_path (ref SKMatrix matrix, sk_path_t path);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_path_effect_t sk_path_effect_create_dash (float[] intervals, int count, float phase);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_path_effect_t sk_path_effect_create_trim (float start, float stop, SKTrimPathEffectMode mode);

		// color table
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_colortable_unref (sk_colortable_t ctable);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_colortable_t sk_colortable_new ([In] SKPMColor[] colors, int count);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int sk_colortable_count (sk_colortable_t ctable);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_colortable_read_colors (sk_colortable_t ctable, out IntPtr colors);

		// GPU context
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static gr_context_t gr_context_make_gl (gr_glinterface_t glInterface);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void gr_context_unref (gr_context_t context);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void gr_context_abandon_context (gr_context_t context);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void gr_context_release_resources_and_abandon_context (gr_context_t context);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void gr_context_get_resource_cache_limits (gr_context_t context, out int maxResources, out size_t maxResourceBytes);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void gr_context_set_resource_cache_limits (gr_context_t context, int maxResources, size_t maxResourceBytes);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void gr_context_get_resource_cache_usage (gr_context_t context, out int maxResources, out size_t maxResourceBytes);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int gr_context_get_max_surface_sample_count_for_color_type (gr_context_t context, SKColorType colorType);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void gr_context_flush (gr_context_t context);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void gr_context_reset_context (gr_context_t context, UInt32 state);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static GRBackend gr_context_get_backend (gr_context_t context);

		// GL interface
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static gr_glinterface_t gr_glinterface_assemble_interface (voidptr_t ctx, GRGlGetProcDelegateProxyDelegate get);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static gr_glinterface_t gr_glinterface_assemble_gl_interface (voidptr_t ctx, GRGlGetProcDelegateProxyDelegate get);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static gr_glinterface_t gr_glinterface_assemble_gles_interface (voidptr_t ctx, GRGlGetProcDelegateProxyDelegate get);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static gr_glinterface_t gr_glinterface_create_native_interface ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void gr_glinterface_unref (gr_glinterface_t glInterface);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool gr_glinterface_validate (gr_glinterface_t glInterface);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool gr_glinterface_has_extension (gr_glinterface_t glInterface, [MarshalAs (UnmanagedType.LPStr)] string extension);

		// GPU backend texture
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static gr_backendtexture_t gr_backendtexture_new_gl (int width, int height, [MarshalAs (UnmanagedType.I1)] bool mipmapped, ref GRGlTextureInfo glInfo);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void gr_backendtexture_delete (gr_backendtexture_t texture);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool gr_backendtexture_is_valid (gr_backendtexture_t texture);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int gr_backendtexture_get_width (gr_backendtexture_t texture);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int gr_backendtexture_get_height (gr_backendtexture_t texture);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool gr_backendtexture_has_mipmaps (gr_backendtexture_t texture);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static GRBackend gr_backendtexture_get_backend (gr_backendtexture_t texture);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool gr_backendtexture_get_gl_textureinfo (gr_backendtexture_t texture, out GRGlTextureInfo glInfo);

		// GPU backend render target
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static gr_backendrendertarget_t gr_backendrendertarget_new_gl (int width, int height, int samples, int stencils, ref GRGlFramebufferInfo glInfo);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void gr_backendrendertarget_delete (gr_backendrendertarget_t rendertarget);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool gr_backendrendertarget_is_valid (gr_backendrendertarget_t rendertarget);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int gr_backendrendertarget_get_width (gr_backendrendertarget_t rendertarget);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int gr_backendrendertarget_get_height (gr_backendrendertarget_t rendertarget);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int gr_backendrendertarget_get_samples (gr_backendrendertarget_t rendertarget);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static int gr_backendrendertarget_get_stencils (gr_backendrendertarget_t rendertarget);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static GRBackend gr_backendrendertarget_get_backend (gr_backendrendertarget_t rendertarget);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool gr_backendrendertarget_get_gl_framebufferinfo (gr_backendrendertarget_t rendertarget, out GRGlFramebufferInfo glInfo);

		// xml
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_xmlstreamwriter_t sk_xmlstreamwriter_new (sk_wstream_t stream);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_xmlstreamwriter_delete (sk_xmlstreamwriter_t writer);

		// svg
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_canvas_t sk_svgcanvas_create (ref SKRect bounds, sk_xmlwriter_t writer);

		// region
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_region_t sk_region_new ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_region_t sk_region_new2 (sk_region_t r);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_region_contains (sk_region_t r, sk_region_t region);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_region_contains2 (sk_region_t r, int x, int y);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_region_intersects (sk_region_t r, sk_region_t src);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_region_intersects_rect (sk_region_t r, ref SKRectI rect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_region_set_region (sk_region_t r, sk_region_t src);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_region_set_rect (sk_region_t r, ref SKRectI rect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_region_set_path (sk_region_t r, sk_path_t t, sk_region_t clip);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_region_op (sk_region_t r, int left, int top, int right, int bottom, SKRegionOperation op);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_region_op2 (sk_region_t r, sk_region_t src, SKRegionOperation op);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_region_get_bounds (sk_region_t r, out SKRectI rect);

		// vertices
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_vertices_unref (sk_vertices_t cvertices);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_vertices_t sk_vertices_make_copy (SKVertexMode vmode, int vertexCount, [In] SKPoint[] positions, [In] SKPoint[] texs, [In] SKColor[] colors, int indexCount, [In] UInt16[] indices);

		// round rect
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_rrect_t sk_rrect_new ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_rrect_t sk_rrect_new_copy (sk_rrect_t rrect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_rrect_delete (sk_rrect_t rrect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static SKRoundRectType sk_rrect_get_type (sk_rrect_t rrect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_rrect_get_rect (sk_rrect_t rrect, out SKRect rect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_rrect_get_radii (sk_rrect_t rrect, SKRoundRectCorner corner, [Out] out SKPoint radii);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static float sk_rrect_get_width (sk_rrect_t rrect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static float sk_rrect_get_height (sk_rrect_t rrect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_rrect_set_empty (sk_rrect_t rrect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_rrect_set_rect (sk_rrect_t rrect, [In] ref SKRect rect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_rrect_set_oval (sk_rrect_t rrect, [In] ref SKRect rect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_rrect_set_rect_xy (sk_rrect_t rrect, [In] ref SKRect rect, float xRad, float yRad);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_rrect_set_nine_patch (sk_rrect_t rrect, [In] ref SKRect rect, float leftRad, float topRad, float rightRad, float bottomRad);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_rrect_set_rect_radii (sk_rrect_t rrect, [In] ref SKRect rect, [In] SKPoint[] radii);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_rrect_inset (sk_rrect_t rrect, float dx, float dy);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_rrect_outset (sk_rrect_t rrect, float dx, float dy);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_rrect_offset (sk_rrect_t rrect, float dx, float dy);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_rrect_contains (sk_rrect_t rrect, [In] ref SKRect rect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_rrect_is_valid (sk_rrect_t rrect);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.I1)]
		public extern static bool sk_rrect_transform (sk_rrect_t rrect, [In] ref SKMatrix matrix, sk_rrect_t dest);

		// text blob
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_textblob_ref (sk_textblob_t blob);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_textblob_unref (sk_textblob_t blob);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static UInt32 sk_textblob_get_unique_id (sk_textblob_t blob);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_textblob_get_bounds (sk_textblob_t blob, out SKRect bounds);

		// text blob builder
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_textblob_builder_t sk_textblob_builder_new ();
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_textblob_builder_delete (sk_textblob_builder_t builder);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static sk_textblob_t sk_textblob_builder_make (sk_textblob_builder_t builder);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_textblob_builder_alloc_run_text (sk_textblob_builder_t builder, sk_paint_t font, int count, float x, float y, int textByteCount, sk_string_t lang, SKRect* bounds, out SKRunBufferInternal runbuffer);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_textblob_builder_alloc_run_text_pos_h (sk_textblob_builder_t builder, sk_paint_t font, int count, float y, int textByteCount, sk_string_t lang, SKRect* bounds, out SKRunBufferInternal runbuffer);
		[DllImport (SKIA, CallingConvention = CallingConvention.Cdecl)]
		public extern static void sk_textblob_builder_alloc_run_text_pos (sk_textblob_builder_t builder, sk_paint_t font, int count, int textByteCount, sk_string_t lang, SKRect* bounds, out SKRunBufferInternal runbuffer);
	}

#pragma warning restore IDE1006 // Naming Styles
}
