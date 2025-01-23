namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA
{
	using System.ComponentModel;

	/// <summary>
	/// Defines constants related to the EVS IPD-VIA protocol.
	/// </summary>
	internal static class EvsIpdViaProtocol
    {
        /// <summary>
        /// The name of the EVS IPD-VIA protocol.
        /// </summary>
        public static readonly string Name = "EVS IPD-VIA";

		public static class Parameter
		{
			/// <summary>PID: 5 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int debugloggingstate_5 = 5;
			/// <summary>PID: 5 | Type: read</summary>
			public const int debugloggingstate = 5;
			/// <summary>PID: 10 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int checkinterappbufferdummy_10 = 10;
			/// <summary>PID: 10 | Type: read</summary>
			public const int checkinterappbufferdummy = 10;
			/// <summary>PID: 18 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int recordersnames_18 = 18;
			/// <summary>PID: 18 | Type: read</summary>
			public const int recordersnames = 18;
			/// <summary>PID: 19 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int targetsnames_19 = 19;
			/// <summary>PID: 19 | Type: read</summary>
			public const int targetsnames = 19;
			/// <summary>PID: 20 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int targetsparameternames_20 = 20;
			/// <summary>PID: 20 | Type: read</summary>
			public const int targetsparameternames = 20;
			/// <summary>PID: 24 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int checkrabbitmqconnectionqa_24 = 24;
			/// <summary>PID: 24 | Type: read</summary>
			public const int checkrabbitmqconnectionqa = 24;
			/// <summary>PID: 25 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int getmetadatarecordingsessionscollectidsqa_25 = 25;
			/// <summary>PID: 25 | Type: read</summary>
			public const int getmetadatarecordingsessionscollectidsqa = 25;
			/// <summary>PID: 32 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int updatemessagecounter_32 = 32;
			/// <summary>PID: 32 | Type: read</summary>
			public const int updatemessagecounter = 32;
			/// <summary>PID: 33 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int clearrecordingsessions_33 = 33;
			/// <summary>PID: 33 | Type: read</summary>
			public const int clearrecordingsessions = 33;
			/// <summary>PID: 34 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int clearprofilefields_34 = 34;
			/// <summary>PID: 34 | Type: read</summary>
			public const int clearprofilefields = 34;
			/// <summary>PID: 50 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int updatedrecordingsessionid_50 = 50;
			/// <summary>PID: 50 | Type: read</summary>
			public const int updatedrecordingsessionid = 50;
			/// <summary>PID: 101 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int recordingsessionremovaldelay_101 = 101;
			/// <summary>PID: 101 | Type: read</summary>
			public const int recordingsessionremovaldelay = 101;
			/// <summary>PID: 200 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int httpstatuscode_200 = 200;
			/// <summary>PID: 200 | Type: read</summary>
			public const int httpstatuscode = 200;
			/// <summary>PID: 201 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int recordersresponse_201 = 201;
			/// <summary>PID: 201 | Type: read</summary>
			public const int recordersresponse = 201;
			/// <summary>PID: 202 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int targetsresponse_202 = 202;
			/// <summary>PID: 202 | Type: read</summary>
			public const int targetsresponse = 202;
			/// <summary>PID: 203 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int tokenresponse_203 = 203;
			/// <summary>PID: 203 | Type: read</summary>
			public const int tokenresponse = 203;
			/// <summary>PID: 205 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int postrecordingsessionresponse_205 = 205;
			/// <summary>PID: 205 | Type: read</summary>
			public const int postrecordingsessionresponse = 205;
			/// <summary>PID: 206 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int getrecordingsessionresponse_206 = 206;
			/// <summary>PID: 206 | Type: read</summary>
			public const int getrecordingsessionresponse = 206;
			/// <summary>PID: 207 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int putrecordingsessionresponse_207 = 207;
			/// <summary>PID: 207 | Type: read</summary>
			public const int putrecordingsessionresponse = 207;
			/// <summary>PID: 208 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int deleterecordingsessionresponse_208 = 208;
			/// <summary>PID: 208 | Type: read</summary>
			public const int deleterecordingsessionresponse = 208;
			/// <summary>PID: 209 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int getrecordingsessionbyrecorderresponse_209 = 209;
			/// <summary>PID: 209 | Type: read</summary>
			public const int getrecordingsessionbyrecorderresponse = 209;
			/// <summary>PID: 210 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int getmetadatarecordingsessions_210 = 210;
			/// <summary>PID: 210 | Type: read</summary>
			public const int getmetadatarecordingsessions = 210;
			/// <summary>PID: 211 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int getmetadataprofiles_211 = 211;
			/// <summary>PID: 211 | Type: read</summary>
			public const int getmetadataprofiles = 211;
			/// <summary>PID: 212 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int getmetadataprofilebyfqn_212 = 212;
			/// <summary>PID: 212 | Type: read</summary>
			public const int getmetadataprofilebyfqn = 212;
			/// <summary>PID: 250 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int getrecordingsessionbyrecorderid_250 = 250;
			/// <summary>PID: 250 | Type: read</summary>
			public const int getrecordingsessionbyrecorderid = 250;
			/// <summary>PID: 252 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int getrecordingsessionbyrecorderidfromdate_252 = 252;
			/// <summary>PID: 252 | Type: read</summary>
			public const int getrecordingsessionbyrecorderidfromdate = 252;
			/// <summary>PID: 253 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int getrecordingsessionbyrecorderidfromtc_253 = 253;
			/// <summary>PID: 253 | Type: read</summary>
			public const int getrecordingsessionbyrecorderidfromtc = 253;
			/// <summary>PID: 254 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int getrecordingsessionbyrecorderidtodate_254 = 254;
			/// <summary>PID: 254 | Type: read</summary>
			public const int getrecordingsessionbyrecorderidtodate = 254;
			/// <summary>PID: 255 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int getrecordingsessionbyrecorderidtotc_255 = 255;
			/// <summary>PID: 255 | Type: read</summary>
			public const int getrecordingsessionbyrecorderidtotc = 255;
			/// <summary>PID: 300 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int apiconnection_300 = 300;
			/// <summary>PID: 300 | Type: read</summary>
			public const int apiconnection = 300;
			/// <summary>PID: 301 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int username_301 = 301;
			/// <summary>PID: 301 | Type: read</summary>
			public const int username = 301;
			/// <summary>PID: 302 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int password_302 = 302;
			/// <summary>PID: 302 | Type: read</summary>
			public const int password = 302;
			/// <summary>PID: 303 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int getrecordingsessionbyidurl_303 = 303;
			/// <summary>PID: 303 | Type: read</summary>
			public const int getrecordingsessionbyidurl = 303;
			/// <summary>PID: 304 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int putrecordingsessionbyidurl_304 = 304;
			/// <summary>PID: 304 | Type: read</summary>
			public const int putrecordingsessionbyidurl = 304;
			/// <summary>PID: 305 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int deleterecordingsessionbyidurl_305 = 305;
			/// <summary>PID: 305 | Type: read</summary>
			public const int deleterecordingsessionbyidurl = 305;
			/// <summary>PID: 306 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int putrecordingsessionbody_306 = 306;
			/// <summary>PID: 306 | Type: read</summary>
			public const int putrecordingsessionbody = 306;
			/// <summary>PID: 308 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int postrecordingsessionbody_308 = 308;
			/// <summary>PID: 308 | Type: read</summary>
			public const int postrecordingsessionbody = 308;
			/// <summary>PID: 309 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int bearertoken_309 = 309;
			/// <summary>PID: 309 | Type: read</summary>
			public const int bearertoken = 309;
			/// <summary>PID: 310 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int getmetadatarecordingsessionsbody_310 = 310;
			/// <summary>PID: 310 | Type: read</summary>
			public const int getmetadatarecordingsessionsbody = 310;
			/// <summary>PID: 311 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int getmetadataprofilebyfqnurl_311 = 311;
			/// <summary>PID: 311 | Type: read</summary>
			public const int getmetadataprofilebyfqnurl = 311;
			/// <summary>PID: 400 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int rabbitmqusername_400 = 400;
			/// <summary>PID: 400 | Type: read</summary>
			public const int rabbitmqusername = 400;
			/// <summary>PID: 402 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int rabbitmqpassword_402 = 402;
			/// <summary>PID: 402 | Type: read</summary>
			public const int rabbitmqpassword = 402;
			/// <summary>PID: 404 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int rabbitmqipaddress_404 = 404;
			/// <summary>PID: 404 | Type: read</summary>
			public const int rabbitmqipaddress = 404;
			/// <summary>PID: 406 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int rabbitmqport_406 = 406;
			/// <summary>PID: 406 | Type: read</summary>
			public const int rabbitmqport = 406;
			/// <summary>PID: 408 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int virtualhost_408 = 408;
			/// <summary>PID: 408 | Type: read</summary>
			public const int virtualhost = 408;
			/// <summary>PID: 414 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int rabbitmqlastmessage_414 = 414;
			/// <summary>PID: 414 | Type: read</summary>
			public const int rabbitmqlastmessage = 414;
			/// <summary>PID: 415 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int rabbitmqdebuglogging_415 = 415;
			/// <summary>PID: 415 | Type: read</summary>
			public const int rabbitmqdebuglogging = 415;
			/// <summary>PID: 417 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int rabbitmqmessageslasthour_417 = 417;
			/// <summary>PID: 417 | Type: read</summary>
			public const int rabbitmqmessageslasthour = 417;
			/// <summary>PID: 441 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int rabbitmqconnectionstatus_441 = 441;
			/// <summary>PID: 441 | Type: read</summary>
			public const int rabbitmqconnectionstatus = 441;
			/// <summary>PID: 442 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int rabbitmqcommunicationstatus_442 = 442;
			/// <summary>PID: 442 | Type: read</summary>
			public const int rabbitmqcommunicationstatus = 442;
			/// <summary>PID: 500 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int interapptimeout_500 = 500;
			/// <summary>PID: 500 | Type: read</summary>
			public const int interapptimeout = 500;
			/// <summary>PID: 999 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int recordingsessionmessage_999 = 999;
			/// <summary>PID: 999 | Type: read</summary>
			public const int recordingsessionmessage = 999;
			/// <summary>PID: 2101 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int targetnamesdiscreetvalues_2101 = 2101;
			/// <summary>PID: 2101 | Type: read</summary>
			public const int targetnamesdiscreetvalues = 2101;
			/// <summary>PID: 2102 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int targetparametersdiscreetvalues_2102 = 2102;
			/// <summary>PID: 2102 | Type: read</summary>
			public const int targetparametersdiscreetvalues = 2102;
			/// <summary>PID: 2103 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int targetparametervalue_2103 = 2103;
			/// <summary>PID: 2103 | Type: read</summary>
			public const int targetparametervalue = 2103;
			/// <summary>PID: 9000000 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int clp_interapp_receive_9000000 = 9000000;
			/// <summary>PID: 9000000 | Type: read</summary>
			public const int clp_interapp_receive = 9000000;
			/// <summary>PID: 9000001 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int clp_interapp_return_9000001 = 9000001;
			/// <summary>PID: 9000001 | Type: read</summary>
			public const int clp_interapp_return = 9000001;
			
			public static class Write
			{
				/// <summary>PID: 6 | Type: write</summary>
				[EditorBrowsable(EditorBrowsableState.Never)]
				public const int debugloggingstate_6 = 6;
				/// <summary>PID: 21 | Type: write</summary>
				[EditorBrowsable(EditorBrowsableState.Never)]
				public const int refreshrecorders_21 = 21;
				/// <summary>PID: 21 | Type: write</summary>
				public const int refreshrecorders = 21;
				/// <summary>PID: 22 | Type: write</summary>
				[EditorBrowsable(EditorBrowsableState.Never)]
				public const int refreshtargets_22 = 22;
				/// <summary>PID: 22 | Type: write</summary>
				public const int refreshtargets = 22;
				/// <summary>PID: 131 | Type: write</summary>
				[EditorBrowsable(EditorBrowsableState.Never)]
				public const int recordingsessionremovaldelay_131 = 131;

				/// <summary>PID: 351 | Type: write</summary>
				[EditorBrowsable(EditorBrowsableState.Never)]
				public const int username_351 = 351;

				/// <summary>PID: 352 | Type: write</summary>
				[EditorBrowsable(EditorBrowsableState.Never)]
				public const int password_352 = 352;

				/// <summary>PID: 401 | Type: write</summary>
				[EditorBrowsable(EditorBrowsableState.Never)]
				public const int rabbitmqusername_401 = 401;

				/// <summary>PID: 403 | Type: write</summary>
				[EditorBrowsable(EditorBrowsableState.Never)]
				public const int rabbitmqpassword_403 = 403;

				/// <summary>PID: 405 | Type: write</summary>
				[EditorBrowsable(EditorBrowsableState.Never)]
				public const int rabbitmqipaddress_405 = 405;

				/// <summary>PID: 407 | Type: write</summary>
				[EditorBrowsable(EditorBrowsableState.Never)]
				public const int rabbitmqport_407 = 407;

				/// <summary>PID: 409 | Type: write</summary>
				[EditorBrowsable(EditorBrowsableState.Never)]
				public const int virtualhost_409 = 409;
	
				/// <summary>PID: 416 | Type: write</summary>
				[EditorBrowsable(EditorBrowsableState.Never)]
				public const int rabbitmqdebuglogging_416 = 416;

				/// <summary>PID: 550 | Type: write</summary>
				[EditorBrowsable(EditorBrowsableState.Never)]
				public const int interapptimeout_550 = 550;

				/// <summary>PID: 1450 | Type: write</summary>
				[EditorBrowsable(EditorBrowsableState.Never)]
				public const int refreshrecordingsessions_1450 = 1450;
				/// <summary>PID: 1450 | Type: write</summary>
				public const int refreshrecordingsessions = 1450;
				/// <summary>PID: 2054 | Type: write</summary>
				[EditorBrowsable(EditorBrowsableState.Never)]
				public const int targetsconfigvalue_2054 = 2054;
				/// <summary>PID: 2054 | Type: write</summary>
				public const int targetsconfigvalue = 2054;
				/// <summary>PID: 2100 | Type: write</summary>
				[EditorBrowsable(EditorBrowsableState.Never)]
				public const int targetsconfig_contextmenu_2100 = 2100;
				/// <summary>PID: 2100 | Type: write</summary>
				public const int targetsconfig_contextmenu = 2100;
			}

			public static class Recorders
			{
				/// <summary>PID: 1000</summary>
				public const int tablePid = 1000;
				/// <summary>IDX: 0</summary>
				public const int indexColumn = 0;
				/// <summary>PID: 1001</summary>
				public const int indexColumnPid = 1001;
				public static class Pid
				{
					/// <summary>PID: 1001 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordersinstance_1001 = 1001;
					/// <summary>PID: 1001 | Type: read</summary>
					public const int recordersinstance = 1001;
					/// <summary>PID: 1002 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordersname_1002 = 1002;
					/// <summary>PID: 1002 | Type: read</summary>
					public const int recordersname = 1002;
					/// <summary>PID: 1003 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordersstatus_1003 = 1003;
					/// <summary>PID: 1003 | Type: read</summary>
					public const int recordersstatus = 1003;
					/// <summary>PID: 1004 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordersservername_1004 = 1004;
					/// <summary>PID: 1004 | Type: read</summary>
					public const int recordersservername = 1004;
				}
				public static class Idx
				{
					/// <summary>IDX: 0 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordersinstance_1001 = 0;
					/// <summary>IDX: 0 | Type: read</summary>
					public const int recordersinstance = 0;
					/// <summary>IDX: 1 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordersname_1002 = 1;
					/// <summary>IDX: 1 | Type: read</summary>
					public const int recordersname = 1;
					/// <summary>IDX: 2 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordersstatus_1003 = 2;
					/// <summary>IDX: 2 | Type: read</summary>
					public const int recordersstatus = 2;
					/// <summary>IDX: 3 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordersservername_1004 = 3;
					/// <summary>IDX: 3 | Type: read</summary>
					public const int recordersservername = 3;
				}
			}
			public static class Targets
			{
				/// <summary>PID: 1100</summary>
				public const int tablePid = 1100;
				/// <summary>IDX: 0</summary>
				public const int indexColumn = 0;
				/// <summary>PID: 1101</summary>
				public const int indexColumnPid = 1101;
				public static class Pid
				{
					/// <summary>PID: 1101 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int targetsinstance_1101 = 1101;
					/// <summary>PID: 1101 | Type: read</summary>
					public const int targetsinstance = 1101;
					/// <summary>PID: 1102 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int targetsname_1102 = 1102;
					/// <summary>PID: 1102 | Type: read</summary>
					public const int targetsname = 1102;
					/// <summary>PID: 1103 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int targetsworkflowdefinitionname_1103 = 1103;
					/// <summary>PID: 1103 | Type: read</summary>
					public const int targetsworkflowdefinitionname = 1103;
					/// <summary>PID: 1104 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int targetstargetparameters_1104 = 1104;
					/// <summary>PID: 1104 | Type: read</summary>
					public const int targetstargetparameters = 1104;

				}
				public static class Idx
				{
					/// <summary>IDX: 0 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int targetsinstance_1101 = 0;
					/// <summary>IDX: 0 | Type: read</summary>
					public const int targetsinstance = 0;
					/// <summary>IDX: 1 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int targetsname_1102 = 1;
					/// <summary>IDX: 1 | Type: read</summary>
					public const int targetsname = 1;
					/// <summary>IDX: 2 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int targetsworkflowdefinitionname_1103 = 2;
					/// <summary>IDX: 2 | Type: read</summary>
					public const int targetsworkflowdefinitionname = 2;
					/// <summary>IDX: 3 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int targetstargetparameters_1104 = 3;
					/// <summary>IDX: 3 | Type: read</summary>
					public const int targetstargetparameters = 3;
				}
			}
			public static class Servers
			{
				/// <summary>PID: 1300</summary>
				public const int tablePid = 1300;
				/// <summary>IDX: 0</summary>
				public const int indexColumn = 0;
				/// <summary>PID: 1301</summary>
				public const int indexColumnPid = 1301;
				public static class Pid
				{
					/// <summary>PID: 1301 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int serversinstance_1301 = 1301;
					/// <summary>PID: 1301 | Type: read</summary>
					public const int serversinstance = 1301;
					/// <summary>PID: 1302 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int serversname_1302 = 1302;
					/// <summary>PID: 1302 | Type: read</summary>
					public const int serversname = 1302;
					/// <summary>PID: 1303 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int serversstatus_1303 = 1303;
					/// <summary>PID: 1303 | Type: read</summary>
					public const int serversstatus = 1303;

				}
				public static class Idx
				{
					/// <summary>IDX: 0 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int serversinstance_1301 = 0;
					/// <summary>IDX: 0 | Type: read</summary>
					public const int serversinstance = 0;
					/// <summary>IDX: 1 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int serversname_1302 = 1;
					/// <summary>IDX: 1 | Type: read</summary>
					public const int serversname = 1;
					/// <summary>IDX: 2 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int serversstatus_1303 = 2;
					/// <summary>IDX: 2 | Type: read</summary>
					public const int serversstatus = 2;
				}
			}
			public class Recordingsessions
			{
				/// <summary>PID: 1400</summary>
				public const int tablePid = 1400;
				/// <summary>IDX: 0</summary>
				public const int indexColumn = 0;
				/// <summary>PID: 1401</summary>
				public const int indexColumnPid = 1401;
				public static class Pid
				{
					/// <summary>PID: 1401 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsinstance_1401 = 1401;
					/// <summary>PID: 1401 | Type: read</summary>
					public const int recordingsessionsinstance = 1401;
					/// <summary>PID: 1402 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsname_1402 = 1402;
					/// <summary>PID: 1402 | Type: read</summary>
					public const int recordingsessionsname = 1402;
					/// <summary>PID: 1403 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsstatus_1403 = 1403;
					/// <summary>PID: 1403 | Type: read</summary>
					public const int recordingsessionsstatus = 1403;
					/// <summary>PID: 1404 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsdatein_1404 = 1404;
					/// <summary>PID: 1404 | Type: read</summary>
					public const int recordingsessionsdatein = 1404;
					/// <summary>PID: 1406 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsdateout_1406 = 1406;
					/// <summary>PID: 1406 | Type: read</summary>
					public const int recordingsessionsdateout = 1406;
					/// <summary>PID: 1408 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsrecordername_1408 = 1408;
					/// <summary>PID: 1408 | Type: read</summary>
					public const int recordingsessionsrecordername = 1408;
					/// <summary>PID: 1409 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsrecorderid_1409 = 1409;
					/// <summary>PID: 1409 | Type: read</summary>
					public const int recordingsessionsrecorderid = 1409;
					public static class Write
					{
						/// <summary>PID: 1412 | Type: write</summary>
						[EditorBrowsable(EditorBrowsableState.Never)]
						public const int recordingsessionsrefresh_1412 = 1412;
						/// <summary>PID: 1412 | Type: write</summary>
						public const int recordingsessionsrefresh = 1412;
					}
				}
				public static class Idx
				{
					/// <summary>IDX: 0 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsinstance_1401 = 0;
					/// <summary>IDX: 0 | Type: read</summary>
					public const int recordingsessionsinstance = 0;
					/// <summary>IDX: 1 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsname_1402 = 1;
					/// <summary>IDX: 1 | Type: read</summary>
					public const int recordingsessionsname = 1;
					/// <summary>IDX: 2 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsstatus_1403 = 2;
					/// <summary>IDX: 2 | Type: read</summary>
					public const int recordingsessionsstatus = 2;
					/// <summary>IDX: 3 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsdatein_1404 = 3;
					/// <summary>IDX: 3 | Type: read</summary>
					public const int recordingsessionsdatein = 3;
					/// <summary>IDX: 4 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsdateout_1406 = 4;
					/// <summary>IDX: 4 | Type: read</summary>
					public const int recordingsessionsdateout = 4;
					/// <summary>IDX: 5 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsrecordername_1408 = 5;
					/// <summary>IDX: 5 | Type: read</summary>
					public const int recordingsessionsrecordername = 5;
					/// <summary>IDX: 6 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsrecorderid_1409 = 6;
					/// <summary>IDX: 6 | Type: read</summary>
					public const int recordingsessionsrecorderid = 6;
				}
			}
			public static class Recordingsessionstargets
			{
				/// <summary>PID: 1500</summary>
				public const int tablePid = 1500;
				/// <summary>IDX: 0</summary>
				public const int indexColumn = 0;
				/// <summary>PID: 1501</summary>
				public const int indexColumnPid = 1501;
				public static class Pid
				{
					/// <summary>PID: 1501 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionstargetsinstance_1501 = 1501;
					/// <summary>PID: 1501 | Type: read</summary>
					public const int recordingsessionstargetsinstance = 1501;
					/// <summary>PID: 1502 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionstargetsrecordingsessionddisplaykey_1502 = 1502;
					/// <summary>PID: 1502 | Type: read</summary>
					public const int recordingsessionstargetsrecordingsessionddisplaykey = 1502;
					/// <summary>PID: 1503 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionstargetsrecordingsessioninstance_1503 = 1503;
					/// <summary>PID: 1503 | Type: read</summary>
					public const int recordingsessionstargetsrecordingsessioninstance = 1503;
					/// <summary>PID: 1504 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionstargetsrecordingsession_1504 = 1504;
					/// <summary>PID: 1504 | Type: read</summary>
					public const int recordingsessionstargetsrecordingsession = 1504;
					/// <summary>PID: 1505 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionstargetstargetinstance_1505 = 1505;
					/// <summary>PID: 1505 | Type: read</summary>
					public const int recordingsessionstargetstargetinstance = 1505;
					/// <summary>PID: 1506 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionstargetstarget_1506 = 1506;
					/// <summary>PID: 1506 | Type: read</summary>
					public const int recordingsessionstargetstarget = 1506;
				}
				public static class Idx
				{
					/// <summary>IDX: 0 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionstargetsinstance_1501 = 0;
					/// <summary>IDX: 0 | Type: read</summary>
					public const int recordingsessionstargetsinstance = 0;
					/// <summary>IDX: 1 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionstargetsrecordingsessionddisplaykey_1502 = 1;
					/// <summary>IDX: 1 | Type: read</summary>
					public const int recordingsessionstargetsrecordingsessionddisplaykey = 1;
					/// <summary>IDX: 2 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionstargetsrecordingsessioninstance_1503 = 2;
					/// <summary>IDX: 2 | Type: read</summary>
					public const int recordingsessionstargetsrecordingsessioninstance = 2;
					/// <summary>IDX: 3 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionstargetsrecordingsession_1504 = 3;
					/// <summary>IDX: 3 | Type: read</summary>
					public const int recordingsessionstargetsrecordingsession = 3;
					/// <summary>IDX: 4 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionstargetstargetinstance_1505 = 4;
					/// <summary>IDX: 4 | Type: read</summary>
					public const int recordingsessionstargetstargetinstance = 4;
					/// <summary>IDX: 5 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionstargetstarget_1506 = 5;
					/// <summary>IDX: 5 | Type: read</summary>
					public const int recordingsessionstargetstarget = 5;
				}
			}
			public static class Recordingsessionsprofiles
			{
				/// <summary>PID: 1600</summary>
				public const int tablePid = 1600;
				/// <summary>IDX: 0</summary>
				public const int indexColumn = 0;
				/// <summary>PID: 1601</summary>
				public const int indexColumnPid = 1601;
				public static class Pid
				{
					/// <summary>PID: 1601 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsprofilesinstance_1601 = 1601;
					/// <summary>PID: 1601 | Type: read</summary>
					public const int recordingsessionsprofilesinstance = 1601;
					/// <summary>PID: 1602 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsprofilesrecordingsession_1602 = 1602;
					/// <summary>PID: 1602 | Type: read</summary>
					public const int recordingsessionsprofilesrecordingsession = 1602;
					/// <summary>PID: 1603 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsprofilesprofile_1603 = 1603;
					/// <summary>PID: 1603 | Type: read</summary>
					public const int recordingsessionsprofilesprofile = 1603;
					/// <summary>PID: 1604 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsprofilesrecordingsessionid_1604 = 1604;
					/// <summary>PID: 1604 | Type: read</summary>
					public const int recordingsessionsprofilesrecordingsessionid = 1604;
					/// <summary>PID: 1605 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsprofilesdisplaykey_1605 = 1605;
					/// <summary>PID: 1605 | Type: read</summary>
					public const int recordingsessionsprofilesdisplaykey = 1605;
				}
				public static class Idx
				{
					/// <summary>IDX: 0 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsprofilesinstance_1601 = 0;
					/// <summary>IDX: 0 | Type: read</summary>
					public const int recordingsessionsprofilesinstance = 0;
					/// <summary>IDX: 1 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsprofilesrecordingsession_1602 = 1;
					/// <summary>IDX: 1 | Type: read</summary>
					public const int recordingsessionsprofilesrecordingsession = 1;
					/// <summary>IDX: 2 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsprofilesprofile_1603 = 2;
					/// <summary>IDX: 2 | Type: read</summary>
					public const int recordingsessionsprofilesprofile = 2;
					/// <summary>IDX: 3 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsprofilesrecordingsessionid_1604 = 3;
					/// <summary>IDX: 3 | Type: read</summary>
					public const int recordingsessionsprofilesrecordingsessionid = 3;
					/// <summary>IDX: 4 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsprofilesdisplaykey_1605 = 4;
					/// <summary>IDX: 4 | Type: read</summary>
					public const int recordingsessionsprofilesdisplaykey = 4;
				}
			}
			public static class Recordingsessionsmetadatavalues
			{
				/// <summary>PID: 1700</summary>
				public const int tablePid = 1700;
				/// <summary>IDX: 0</summary>
				public const int indexColumn = 0;
				/// <summary>PID: 1701</summary>
				public const int indexColumnPid = 1701;
				public static class Pid
				{
					/// <summary>PID: 1701 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsmetadatavaluesinstance_1701 = 1701;
					/// <summary>PID: 1701 | Type: read</summary>
					public const int recordingsessionsmetadatavaluesinstance = 1701;
					/// <summary>PID: 1702 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsmetadatavalueskey_1702 = 1702;
					/// <summary>PID: 1702 | Type: read</summary>
					public const int recordingsessionsmetadatavalueskey = 1702;
					/// <summary>PID: 1703 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsmetadatavaluesvalue_1703 = 1703;
					/// <summary>PID: 1703 | Type: read</summary>
					public const int recordingsessionsmetadatavaluesvalue = 1703;
					/// <summary>PID: 1704 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsmetadatavaluesrecordingsession_1704 = 1704;
					/// <summary>PID: 1704 | Type: read</summary>
					public const int recordingsessionsmetadatavaluesrecordingsession = 1704;
					/// <summary>PID: 1705 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsmetadatavaluesrecordingsessionid_1705 = 1705;
					/// <summary>PID: 1705 | Type: read</summary>
					public const int recordingsessionsmetadatavaluesrecordingsessionid = 1705;
					/// <summary>PID: 1706 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsmetadatavaluesdisplaykey_1706 = 1706;
					/// <summary>PID: 1706 | Type: read</summary>
					public const int recordingsessionsmetadatavaluesdisplaykey = 1706;
					/// <summary>PID: 1707 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsmetadatavaluesprofile_1707 = 1707;
					/// <summary>PID: 1707 | Type: read</summary>
					public const int recordingsessionsmetadatavaluesprofile = 1707;
					/// <summary>PID: 1708 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsmetadatavaluesprofileid_1708 = 1708;
					/// <summary>PID: 1708 | Type: read</summary>
					public const int recordingsessionsmetadatavaluesprofileid = 1708;

				}
				public static class Idx
				{
					/// <summary>IDX: 0 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsmetadatavaluesinstance_1701 = 0;
					/// <summary>IDX: 0 | Type: read</summary>
					public const int recordingsessionsmetadatavaluesinstance = 0;
					/// <summary>IDX: 1 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsmetadatavalueskey_1702 = 1;
					/// <summary>IDX: 1 | Type: read</summary>
					public const int recordingsessionsmetadatavalueskey = 1;
					/// <summary>IDX: 2 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsmetadatavaluesvalue_1703 = 2;
					/// <summary>IDX: 2 | Type: read</summary>
					public const int recordingsessionsmetadatavaluesvalue = 2;
					/// <summary>IDX: 3 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsmetadatavaluesrecordingsession_1704 = 3;
					/// <summary>IDX: 3 | Type: read</summary>
					public const int recordingsessionsmetadatavaluesrecordingsession = 3;
					/// <summary>IDX: 4 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsmetadatavaluesrecordingsessionid_1705 = 4;
					/// <summary>IDX: 4 | Type: read</summary>
					public const int recordingsessionsmetadatavaluesrecordingsessionid = 4;
					/// <summary>IDX: 5 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsmetadatavaluesdisplaykey_1706 = 5;
					/// <summary>IDX: 5 | Type: read</summary>
					public const int recordingsessionsmetadatavaluesdisplaykey = 5;
					/// <summary>IDX: 6 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsmetadatavaluesprofile_1707 = 6;
					/// <summary>IDX: 6 | Type: read</summary>
					public const int recordingsessionsmetadatavaluesprofile = 6;
					/// <summary>IDX: 7 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int recordingsessionsmetadatavaluesprofileid_1708 = 7;
					/// <summary>IDX: 7 | Type: read</summary>
					public const int recordingsessionsmetadatavaluesprofileid = 7;
				}
			}
			public static class Profiles
			{
				/// <summary>PID: 1800</summary>
				public const int tablePid = 1800;
				/// <summary>IDX: 0</summary>
				public const int indexColumn = 0;
				/// <summary>PID: 1801</summary>
				public const int indexColumnPid = 1801;
				public static class Pid
				{
					/// <summary>PID: 1801 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilesinstance_1801 = 1801;
					/// <summary>PID: 1801 | Type: read</summary>
					public const int profilesinstance = 1801;
					/// <summary>PID: 1802 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilestype_1802 = 1802;
					/// <summary>PID: 1802 | Type: read</summary>
					public const int profilestype = 1802;
					/// <summary>PID: 1803 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilesstatus_1803 = 1803;
					/// <summary>PID: 1803 | Type: read</summary>
					public const int profilesstatus = 1803;
					/// <summary>PID: 1804 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilesfqn_1804 = 1804;
					/// <summary>PID: 1804 | Type: read</summary>
					public const int profilesfqn = 1804;
					/// <summary>PID: 1805 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilescreationdate_1805 = 1805;
					/// <summary>PID: 1805 | Type: read</summary>
					public const int profilescreationdate = 1805;
					/// <summary>PID: 1806 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilesmodificationdate_1806 = 1806;
					/// <summary>PID: 1806 | Type: read</summary>
					public const int profilesmodificationdate = 1806;
					/// <summary>PID: 1807 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilessource_1807 = 1807;
					/// <summary>PID: 1807 | Type: read</summary>
					public const int profilessource = 1807;
					/// <summary>PID: 1808 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilesname_1808 = 1808;
					/// <summary>PID: 1808 | Type: read</summary>
					public const int profilesname = 1808;
					/// <summary>PID: 1809 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilesdescription_1809 = 1809;
					/// <summary>PID: 1809 | Type: read</summary>
					public const int profilesdescription = 1809;
				}
				public static class Idx
				{
					/// <summary>IDX: 0 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilesinstance_1801 = 0;
					/// <summary>IDX: 0 | Type: read</summary>
					public const int profilesinstance = 0;
					/// <summary>IDX: 1 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilestype_1802 = 1;
					/// <summary>IDX: 1 | Type: read</summary>
					public const int profilestype = 1;
					/// <summary>IDX: 2 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilesstatus_1803 = 2;
					/// <summary>IDX: 2 | Type: read</summary>
					public const int profilesstatus = 2;
					/// <summary>IDX: 3 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilesfqn_1804 = 3;
					/// <summary>IDX: 3 | Type: read</summary>
					public const int profilesfqn = 3;
					/// <summary>IDX: 4 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilescreationdate_1805 = 4;
					/// <summary>IDX: 4 | Type: read</summary>
					public const int profilescreationdate = 4;
					/// <summary>IDX: 5 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilesmodificationdate_1806 = 5;
					/// <summary>IDX: 5 | Type: read</summary>
					public const int profilesmodificationdate = 5;
					/// <summary>IDX: 6 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilessource_1807 = 6;
					/// <summary>IDX: 6 | Type: read</summary>
					public const int profilessource = 6;
					/// <summary>IDX: 7 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilesname_1808 = 7;
					/// <summary>IDX: 7 | Type: read</summary>
					public const int profilesname = 7;
					/// <summary>IDX: 8 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilesdescription_1809 = 8;
					/// <summary>IDX: 8 | Type: read</summary>
					public const int profilesdescription = 8;
				}
			}
			public static class Profilefields
			{
				/// <summary>PID: 1900</summary>
				public const int tablePid = 1900;
				/// <summary>IDX: 0</summary>
				public const int indexColumn = 0;
				/// <summary>PID: 1901</summary>
				public const int indexColumnPid = 1901;
				public static class Pid
				{
					/// <summary>PID: 1901 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldsinstance_1901 = 1901;
					/// <summary>PID: 1901 | Type: read</summary>
					public const int profilefieldsinstance = 1901;
					/// <summary>PID: 1902 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldskey_1902 = 1902;
					/// <summary>PID: 1902 | Type: read</summary>
					public const int profilefieldskey = 1902;
					/// <summary>PID: 1903 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldslabel_1903 = 1903;
					/// <summary>PID: 1903 | Type: read</summary>
					public const int profilefieldslabel = 1903;
					/// <summary>PID: 1904 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldstype_1904 = 1904;
					/// <summary>PID: 1904 | Type: read</summary>
					public const int profilefieldstype = 1904;
					/// <summary>PID: 1905 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldsrequired_1905 = 1905;
					/// <summary>PID: 1905 | Type: read</summary>
					public const int profilefieldsrequired = 1905;
					/// <summary>PID: 1906 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldsvalueconstraints_1906 = 1906;
					/// <summary>PID: 1906 | Type: read</summary>
					public const int profilefieldsvalueconstraints = 1906;
					/// <summary>PID: 1907 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldspredefinedvalue_1907 = 1907;
					/// <summary>PID: 1907 | Type: read</summary>
					public const int profilefieldspredefinedvalue = 1907;
					/// <summary>PID: 1908 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldsprofilefqn_1908 = 1908;
					/// <summary>PID: 1908 | Type: read</summary>
					public const int profilefieldsprofilefqn = 1908;
					/// <summary>PID: 1909 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldsprofilename_1909 = 1909;
					/// <summary>PID: 1909 | Type: read</summary>
					public const int profilefieldsprofilename = 1909;
					/// <summary>PID: 1910 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldsdisplaykey_1910 = 1910;
					/// <summary>PID: 1910 | Type: read</summary>
					public const int profilefieldsdisplaykey = 1910;
					/// <summary>PID: 1911 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldsfqncontraints_1911 = 1911;
					/// <summary>PID: 1911 | Type: read</summary>
					public const int profilefieldsfqncontraints = 1911;
				}
				public static class Idx
				{
					/// <summary>IDX: 0 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldsinstance_1901 = 0;
					/// <summary>IDX: 0 | Type: read</summary>
					public const int profilefieldsinstance = 0;
					/// <summary>IDX: 1 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldskey_1902 = 1;
					/// <summary>IDX: 1 | Type: read</summary>
					public const int profilefieldskey = 1;
					/// <summary>IDX: 2 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldslabel_1903 = 2;
					/// <summary>IDX: 2 | Type: read</summary>
					public const int profilefieldslabel = 2;
					/// <summary>IDX: 3 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldstype_1904 = 3;
					/// <summary>IDX: 3 | Type: read</summary>
					public const int profilefieldstype = 3;
					/// <summary>IDX: 4 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldsrequired_1905 = 4;
					/// <summary>IDX: 4 | Type: read</summary>
					public const int profilefieldsrequired = 4;
					/// <summary>IDX: 5 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldsvalueconstraints_1906 = 5;
					/// <summary>IDX: 5 | Type: read</summary>
					public const int profilefieldsvalueconstraints = 5;
					/// <summary>IDX: 6 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldspredefinedvalue_1907 = 6;
					/// <summary>IDX: 6 | Type: read</summary>
					public const int profilefieldspredefinedvalue = 6;
					/// <summary>IDX: 7 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldsprofilefqn_1908 = 7;
					/// <summary>IDX: 7 | Type: read</summary>
					public const int profilefieldsprofilefqn = 7;
					/// <summary>IDX: 8 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldsprofilename_1909 = 8;
					/// <summary>IDX: 8 | Type: read</summary>
					public const int profilefieldsprofilename = 8;
					/// <summary>IDX: 9 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldsdisplaykey_1910 = 9;
					/// <summary>IDX: 9 | Type: read</summary>
					public const int profilefieldsdisplaykey = 9;
					/// <summary>IDX: 10 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int profilefieldsfqncontraints_1911 = 10;
					/// <summary>IDX: 10 | Type: read</summary>
					public const int profilefieldsfqncontraints = 10;
				}
			}
			public static class Targetsconfig
			{
				/// <summary>PID: 2000</summary>
				public const int tablePid = 2000;
				/// <summary>IDX: 0</summary>
				public const int indexColumn = 0;
				/// <summary>PID: 2001</summary>
				public const int indexColumnPid = 2001;
				public static class Pid
				{
					/// <summary>PID: 2001 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int targetsconfiginstance_2001 = 2001;
					/// <summary>PID: 2001 | Type: read</summary>
					public const int targetsconfiginstance = 2001;
					/// <summary>PID: 2002 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int targetsconfigtargetref_2002 = 2002;
					/// <summary>PID: 2002 | Type: read</summary>
					public const int targetsconfigtargetref = 2002;
					/// <summary>PID: 2003 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int targetsconfigparametername_2003 = 2003;
					/// <summary>PID: 2003 | Type: read</summary>
					public const int targetsconfigparametername = 2003;
					/// <summary>PID: 2004 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int targetsconfigvalue_2004 = 2004;
					/// <summary>PID: 2004 | Type: read</summary>
					public const int targetsconfigvalue = 2004;
				}
				public static class Idx
				{
					/// <summary>IDX: 0 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int targetsconfiginstance_2001 = 0;
					/// <summary>IDX: 0 | Type: read</summary>
					public const int targetsconfiginstance = 0;
					/// <summary>IDX: 1 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int targetsconfigtargetref_2002 = 1;
					/// <summary>IDX: 1 | Type: read</summary>
					public const int targetsconfigtargetref = 1;
					/// <summary>IDX: 2 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int targetsconfigparametername_2003 = 2;
					/// <summary>IDX: 2 | Type: read</summary>
					public const int targetsconfigparametername = 2;
					/// <summary>IDX: 3 | Type: read</summary>
					[EditorBrowsable(EditorBrowsableState.Never)]
					public const int targetsconfigvalue_2004 = 3;
					/// <summary>IDX: 3 | Type: read</summary>
					public const int targetsconfigvalue = 3;
				}
			}
		}

	}
}
