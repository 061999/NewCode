/**  版本信息模板在安装目录下，可自行修改。
* ReportInfo.cs
*
* 功 能： N/A
* 类 名： ReportInfo
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
	/// ReportInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ReportInfo
	{
		public ReportInfo()
		{}
		#region Model
		private int _id;
		private string _roomnumber;
		private string _article;
		private string _submissiontime;
		private string _reportreason;
		private string _zhuangtai;
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
		public string article
		{
			set{ _article=value;}
			get{return _article;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string submissiontime
		{
			set{ _submissiontime=value;}
			get{return _submissiontime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string reportreason
		{
			set{ _reportreason=value;}
			get{return _reportreason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zhuangtai
		{
			set{ _zhuangtai=value;}
			get{return _zhuangtai;}
		}
		#endregion Model

	}
}

