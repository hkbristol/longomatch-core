//
//  Copyright (C) 2008 Andoni Morales Alastruey
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
//
//

namespace LongoMatch.Video.Capturer {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public  class GstVideoCapturer : Gtk.HBox,ICapturer {

		[Obsolete]
		protected GstVideoCapturer(GLib.GType gtype) : base(gtype) {}
		public GstVideoCapturer(IntPtr raw) : base(raw) {}

		[DllImport("libcesarplayer.dll")]
		static extern IntPtr gst_video_capturer_new(int use_type, out IntPtr err);

		public GstVideoCapturer (LongoMatch.Video.Capturer.GvcUseType use_type) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (GstVideoCapturer)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr error = IntPtr.Zero;
			Raw = gst_video_capturer_new((int) use_type, out error);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		

		[GLib.Property ("encode_width")]
		public uint EncodeWidth {
			get {
				GLib.Value val = GetProperty ("encode_width");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("encode_width", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("encode_height")]
		public uint EncodeHeight {
			get {
				GLib.Value val = GetProperty ("encode_height");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("encode_height", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("video_bitrate")]
		public uint VideoBitrate {
			get {
				GLib.Value val = GetProperty ("video_bitrate");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("video_bitrate", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("output_file")]
		public string OutputFile {
			get {
				GLib.Value val = GetProperty ("output_file");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("output_file", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("input_file")]
		public string InputFile {
			get {
				GLib.Value val = GetProperty ("input_file");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("input_file", val);
				val.Dispose ();
			}
		}
		
		
		[GLib.Property ("audio_bitrate")]
		public uint AudioBitrate {
			get {
				GLib.Value val = GetProperty ("audio_bitrate");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("audio_bitrate", val);
				val.Dispose ();
			}
		}
		

		[GLib.Property ("display_width")]
		public uint SourceWidth {
			get {
				GLib.Value val = GetProperty ("display_width");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("display_width", val);
				val.Dispose ();
			}
		}
		
		[GLib.Property ("display_height")]
		public uint SourceHeight {
			get {
				GLib.Value val = GetProperty ("display_height");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("display_height", val);
				val.Dispose ();
			}
		}

		[GLib.CDeclCallback]
		delegate void ErrorSignalDelegate (IntPtr arg0, IntPtr arg1, IntPtr gch);

		static void ErrorSignalCallback (IntPtr arg0, IntPtr arg1, IntPtr gch)
		{
			LongoMatch.Video.Capturer.ErrorArgs args = new LongoMatch.Video.Capturer.ErrorArgs ();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if (sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				args.Args = new object[1];
				args.Args[0] = GLib.Marshaller.Utf8PtrToString (arg1);
				LongoMatch.Video.Capturer.ErrorHandler handler = (LongoMatch.Video.Capturer.ErrorHandler) sig.Handler;
				handler (GLib.Object.GetObject (arg0), args);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.CDeclCallback]
		delegate void ErrorVMDelegate (IntPtr gvc, IntPtr message);

		static ErrorVMDelegate ErrorVMCallback;

		static void error_cb (IntPtr gvc, IntPtr message)
		{
			try {
				GstVideoCapturer gvc_managed = GLib.Object.GetObject (gvc, false) as GstVideoCapturer;
				gvc_managed.OnError (GLib.Marshaller.Utf8PtrToString (message));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideError (GLib.GType gtype)
		{
			if (ErrorVMCallback == null)
				ErrorVMCallback = new ErrorVMDelegate (error_cb);
			OverrideVirtualMethod (gtype, "error", ErrorVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(LongoMatch.Video.Capturer.GstVideoCapturer), ConnectionMethod="OverrideError")]
		protected virtual void OnError (string message)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (message);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("error")]
		public event LongoMatch.Video.Capturer.ErrorHandler Error {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "error", new ErrorSignalDelegate(ErrorSignalCallback));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "error", new ErrorSignalDelegate(ErrorSignalCallback));
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void EosVMDelegate (IntPtr gvc);

		static EosVMDelegate EosVMCallback;

		static void eos_cb (IntPtr gvc)
		{
			try {
				GstVideoCapturer gvc_managed = GLib.Object.GetObject (gvc, false) as GstVideoCapturer;
				gvc_managed.OnEos ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideEos (GLib.GType gtype)
		{
			if (EosVMCallback == null)
				EosVMCallback = new EosVMDelegate (eos_cb);
			OverrideVirtualMethod (gtype, "eos", EosVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(LongoMatch.Video.Capturer.GstVideoCapturer), ConnectionMethod="OverrideEos")]
		protected virtual void OnEos ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("eos")]
		public event System.EventHandler Eos {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "eos");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "eos");
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern void gst_video_capturer_stop(IntPtr raw);

		public void Stop() {
			gst_video_capturer_stop(Handle);
		}

		[DllImport("libcesarplayer.dll")]
		static extern IntPtr gst_video_capturer_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_video_capturer_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}
		[DllImport("libcesarplayer.dll")]
		static extern void gst_video_capturer_start_rec(IntPtr raw);

		public void StartRec() {
			gst_video_capturer_start_rec(Handle);
		}
		[DllImport("libcesarplayer.dll")]
		static extern void gst_video_capturer_rec(IntPtr raw);

		public void Rec() {
			gst_video_capturer_rec(Handle);
		}

		[DllImport("libcesarplayer.dll")]
		static extern void gst_video_capturer_pause(IntPtr raw);

		public void Pause() {
			gst_video_capturer_pause(Handle);
		}



		[DllImport("libcesarplayer.dll")]
		static extern void gst_video_capturer_init_backend(out int argc, IntPtr argv);

		public static int InitBackend(string argv) {
			int argc;
			gst_video_capturer_init_backend(out argc, GLib.Marshaller.StringToPtrGStrdup(argv));
			return argc;
		}


		static GstVideoCapturer ()
		{
			LongoMatch.GtkSharp.Capturer.ObjectManager.Initialize();
		}
#endregion
	}
}
