/**  版本信息模板在安装目录下，可自行修改。
* LivingInfo.cs
*
* 功 能： N/A
* 类 名： LivingInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2021/12/21 9:36:16   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Model
{
	/// <summary>
	/// LivingInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LivingInfo
	{
		public LivingInfo()
		{}
		#region Model
		private int _id;
		private string _roomnumber;
		private string _liveage;
		private string _shouldlive;
		private string _realitylive;
		private string _livemoney;
		private string _phone;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string roomnumber
		{
			set{ _roomnumber=value;}
			get{return _roomnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string liveage
		{
			set{ _liveage=value;}
			get{return _liveage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string shouldlive
		{
			set{ _shouldlive=value;}
			get{return _shouldlive;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string realitylive
		{
			set{ _realitylive=value;}
			get{return _realitylive;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string livemoney
		{
			set{ _livemoney=value;}
			get{return _livemoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		#endregion Model

	}
}

