using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Canvas
{
	[Command(ProtocolName.Canvas.ReplayTraceLog)]
	[SupportedBy("Chrome")]
	public class ReplayTraceLogCommand
	{
		/// <summary>
		/// Gets or sets TraceLogId
		/// </summary>
		public string TraceLogId { get; set; }
		/// <summary>
		/// Gets or sets Last call index in the trace log to replay (zero based).
		/// </summary>
		public long StepNo { get; set; }
	}
}
