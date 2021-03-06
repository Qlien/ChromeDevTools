using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns boxes for the currently selected nodes.
	/// </summary>
	[Command(ProtocolName.DOM.GetBoxModel)]
	[SupportedBy("Chrome")]
	public class GetBoxModelCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to get box model for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
