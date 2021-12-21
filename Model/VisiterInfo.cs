/**  版本信息模板在安装目录下，可自行修改。
* VisiterInfo.cs
*
* 功 能： N/A
* 类 名： VisiterInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2021/12/21 9:36:17   N/A    初版
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
	/// VisiterInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class VisiterInfo
	{
		public VisiterInfo()
		{}
		#region Model
		private int _id;
		private string _visiter;
		private string _visittime;
		private string _visitroom;
		private string _leavetime;
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
		public string visiter
		{
			set{ _visiter=value;}
			get{return _visiter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string visittime
		{
			set{ _visittime=value;}
			get{return _visittime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string visitroom
		{
			set{ _visitroom=value;}
			get{return _visitroom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string leavetime
		{
			set{ _leavetime=value;}
			get{return _leavetime;}
		}
		#endregion Model

	}
}

