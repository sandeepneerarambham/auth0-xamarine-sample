using System;

using UIKit;
using Auth0.OidcClient;
using System.Text;

namespace iOSSample
{
	public partial class MyViewController : UIViewController
	{
		private Auth0Client _client;

		public MyViewController() : base("MyViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			LoginButton.TouchUpInside += LoginButton_TouchUpInside;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		private async void LoginButton_TouchUpInside(object sender, EventArgs e)
		{
            
			_client = new Auth0Client(new Auth0ClientOptions
			{
				Domain = "vjayaram.au.auth0.com",
				ClientId = "i1Rg23kjAOHfqt3Pe4fmwhw2YkkVkV1I",
				Controller = this
			});

			var loginResult = await _client.LoginAsync();

			var sb = new StringBuilder();

			if (loginResult.IsError)
			{
				sb.AppendLine("An error occurred during login:");
				sb.AppendLine(loginResult.Error);
			}
			else
			{
				sb.AppendLine($"ID Token: {loginResult.IdentityToken}");
				sb.AppendLine($"Access Token: {loginResult.AccessToken}");
				sb.AppendLine($"Refresh Token: {loginResult.RefreshToken}");
				sb.AppendLine();
				sb.AppendLine("-- Claims --");
				Console.WriteLine("ID Token {0}", loginResult.IdentityToken);
				Console.WriteLine("Access Token {0}", loginResult.AccessToken);
				Console.WriteLine("Refresh Token {0}", loginResult.RefreshToken);
                Console.WriteLine("Claims");
				foreach (var claim in loginResult.User.Claims)
				{
					sb.AppendLine($"{claim.Type} = {claim.Value}");
                    Console.WriteLine("{0} = {1}", claim.Type, claim.Value);
				}
			}
 
			var alert = UIAlertController.Create("", sb.ToString(), UIAlertControllerStyle.Alert);

			alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Cancel, null));
			PresentViewController(alert, animated: true, completionHandler: null);
            //this.NavigationController.PushViewController(new ProfileViewController(), true);
            /*
            UIStoryboard board = UIStoryboard.FromName("MainStoryboard", null);
			UIViewController ctrl = (UIViewController)board.InstantiateViewController("profileVC");
			ctrl.ModalTransitionStyle = UIModalTransitionStyle.FlipHorizontal;
			this.PresentViewController(ctrl, true, null);
			*/

		}
	}
}

