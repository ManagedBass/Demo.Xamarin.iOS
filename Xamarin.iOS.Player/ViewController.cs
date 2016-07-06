using System;
using Foundation;
using ManagedBass;
using UIKit;

namespace Xamarin.iOS.Player
{
	public partial class ViewController : UIViewController
	{

		private bool _isPlaying = false;
		private int _stream = 0;
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			this.PlayButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				if (this._isPlaying)
				{
					//stop playing
					Bass.StreamFree(this._stream);
					Bass.Free();
					this._stream = 0;
					this.PlayButton.SetTitle("Play", UIControlState.Normal);
					this._isPlaying = false;
				}
				else {
					//start playing
					NSUrl songURL = new NSUrl("Sounds/Sample.mp3");
					Bass.Init();
					this._stream = Bass.CreateStream(songURL.AbsoluteString, 0, 0, BassFlags.Default);
					if (this._stream != 0)
					{
						Bass.ChannelPlay(this._stream);
						this.PlayButton.SetTitle("Stop", UIControlState.Normal);
						this._isPlaying = true;
					}
				}
			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

