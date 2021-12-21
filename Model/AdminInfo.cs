/**  版本信息模板在安装目录下，可自行修改。
* AdminInfo.cs
*
* 功 能： N/A
* 类 名： AdminInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2021/12/21 9:36:15   N/A    初版
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
	/// AdminInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AdminInfo
	{
		public AdminInfo()
		{}
		#region Model
		private int _id;
		private string _adminid="";
		private string _adminpwd;
		private string _adminname="";
		private string _adminage;
		private string _adminsex;
		private string _adminroom;
		private string _adminpost;
		private string _adminadress;
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
		public string adminid
		{
			set{ _adminid=value;}
			get{return _adminid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string adminpwd
		{
			set{ _adminpwd=value;}
			get{return _adminpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string adminname
		{
			set{ _adminname=value;}
			get{return _adminname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string adminage
		{
			set{ _adminage=value;}
			get{return _adminage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string adminsex
		{
			set{ _adminsex=value;}
			get{return _adminsex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string adminroom
		{
			set{ _adminroom=value;}
			get{return _adminroom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string adminpost
		{
			set{ _adminpost=value;}
			get{return _adminpost;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string adminadress
		{
			set{ _adminadress=value;}
			get{return _adminadress;}
		}
		#endregion Model

	}
}

