using System;
using UIKit;
using CoreGraphics;
using OoyalaSDK.iOS;
using OoyalaCastSDK.iOS;
using Foundation;
using System.Collections.Generic;
using ObjCRuntime;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sample.OoyalaSDK.iOS
{
    public class PlayerViewController : UIViewController, IOOCastMiniControllerDelegate, IOOCastManagerDelegate//, IOOAssetDownloadManagerDelegate
    {
        private const string _embedCode = "JiOTdrdzqAujYa5qvnOxszbrTEuU5HMt";

        UIButton _startButton;
        UILabel _downloadProgressLabel;

        OODtoAsset _videoAsset;
        OOOoyalaPlayerViewController _castVC;
        OOCastMiniControllerView _castController;
        OOCastManager castManager;
        NSUrl _cacheLocation;

        public override void LoadView()
        {
            base.LoadView();

            View.BackgroundColor = UIColor.White;

            _downloadProgressLabel = new UILabel()
            {
                Text = "Download state",
                TextColor = UIColor.Magenta,
                TextAlignment = UITextAlignment.Center,
            };
            View.AddSubview(_downloadProgressLabel);

            _startButton = new UIButton(UIButtonType.System);
            _startButton.SetTitle("Click me", UIControlState.Normal);
            View.AddSubview(_startButton);
          
            castManager = OOCastManager.CastManagerWithAppID("4172C76F", "urn:x-cast:ooyala");
            castManager.WeakDelegate = this;

            var options = new OOAssetDownloadOptions();
            options.Pcode = "c0cTkxOqALQviQIGAHWY5hP0q9gU";
            options.EmbedCode = _embedCode;
            options.Domain = new OOPlayerDomain("http://www.ooyala.com");
            _videoAsset = new OODtoAsset(options, "Clear HLS Video");
            _videoAsset.DownloadWithProgressClosure(HandleProgressParameter);
            _videoAsset.FinishWithRelativePath(HandleFinishParameter);
            _videoAsset.OnErrorWithErrorClosure(HandleErrorParameter);
            _downloadProgressLabel.Text = _videoAsset.StateText;
            var castPlayer = new OOOoyalaPlayer(
                pcode: "c0cTkxOqALQviQIGAHWY5hP0q9gU",
                domain: new OOPlayerDomain("http://www.ooyala.com"));
            castPlayer.InitCastManager(castManager);

            var rightButton = new UIBarButtonItem(castManager.CastButton);
            NavigationItem.RightBarButtonItem = rightButton;

            _castVC = new OOOoyalaPlayerViewController(player: castPlayer);
        }

        void HandleErrorParameter(OOOoyalaError arg0)
        {
            Debug.WriteLine($"ERROR: {arg0}");
            _downloadProgressLabel.Text = arg0.Message;
        }


        void HandleProgressParameter(double arg0)
        {
            Debug.WriteLine($"PERCENT COMPLETE: {(arg0 * 100)} %");
            _downloadProgressLabel.Text = $"PERCENT COMPLETE: {(arg0 * 100)} %";
        }


        void HandleFinishParameter(string arg0)
        {
            Debug.WriteLine($"Completed!: {arg0}");
            _downloadProgressLabel.Text = $"Completed!: {arg0}";
            NSString urlString = new NSString(arg0);
            NSUrl myFileUrl = new NSUrl(urlString);
            _cacheLocation = myFileUrl;
        }


        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            _startButton.TouchUpInside += _startButton_TouchUpInside;

            if (castManager.IsMiniControllerInteractionAvailable)
            {
                DisplayMiniController();
            }
        }

        void DisplayMiniController()
        {
            if (_castController == null)
            {
                var tap = new UITapGestureRecognizer(() =>
                {
                    ShowViewController(_castVC, this);
                    NavigationController.SetToolbarHidden(true, true);
                })
                { NumberOfTapsRequired = 1 };

                NavigationController.Toolbar.AddGestureRecognizer(tap);

                _castController = new OOCastMiniControllerView(
                    NavigationController.NavigationBar.Frame,
                    castManager,
                    this
                );

                _castController.Cell.BackgroundColor = UIColor.Clear;

                var player = (OOCastPlayer)castManager.CastPlayer;
                player.RegisterMiniController(_castController);
                _castController.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;

                var miniController = new UIBarButtonItem(_castController);

                var negativeSeparator = new UIBarButtonItem(UIBarButtonSystemItem.FixedSpace);
                negativeSeparator.Width = UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad ? -20 : -16;

                var toolbarItems = new List<UIBarButtonItem>();
                toolbarItems.Add(negativeSeparator);
                toolbarItems.Add(miniController);

                ToolbarItems = toolbarItems.ToArray();
            }

            NavigationController.SetToolbarHidden(false, true);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);

            _startButton.TouchUpInside -= _startButton_TouchUpInside;
        }

        public override void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();

            var bounds = View.Bounds;

            _startButton.Frame = new CGRect(
                20,
                bounds.GetMidY() - 20,
                bounds.Width - 40,
                40
            );

            _downloadProgressLabel.Frame = new CGRect(
                20,
                bounds.GetMidY() - 50,
                bounds.Width - 40,
                40
            );
        }

        void _startButton_TouchUpInside(object sender, System.EventArgs e)
        {
            Debug.WriteLine("Download state :: ", _videoAsset.StateText);
            Debug.WriteLine("Current Download :: ", _videoAsset.CurrentDownload);
            _cacheLocation = _videoAsset.LocalUrl;
            var video = new OOOfflineVideo(_cacheLocation);
            _castVC.Player.SetUnbundledVideo(video);

            ShowViewController(_castVC, this);
            _castVC.NavigationItem.RightBarButtonItem = this.NavigationItem.RightBarButtonItem;
            _castVC.Player.SetEmbedCode(_embedCode);
            _castVC.Player.Play();
        }

        public UIViewController CurrentTopUIViewController
        {
            get
            {
                var vc = UIApplication.SharedApplication.KeyWindow.RootViewController;
                while (vc.PresentedViewController != null)
                    vc = vc.PresentedViewController;
                return vc;
            }
        }
        public void OnDismissMiniController(OOCastMiniControllerProtocol miniControllerView)
        {
            NavigationController.SetToolbarHidden(true, true);
            miniControllerView.Dismiss();
            castManager.DisconnectFromOoyalaPlayer();
        }
    }
}