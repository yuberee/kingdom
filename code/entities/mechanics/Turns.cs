﻿
using Sandbox;
using Sandbox.UI.Construct;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;


public partial class Kingdom : Sandbox.Game
{

	public const float TurnDuration = 0.2f; // How long a turn lasts in seconds
	public static TimeSince LastTurn = 0;

	[Event.Tick.Server]
	public void HandleTurns()
	{

		if ( LastTurn >= TurnDuration )
		{

			Event.Run( "Kingdom_Turn" );
			LastTurn = 0;

		}

	}

}

