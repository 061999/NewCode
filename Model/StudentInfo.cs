/**  版本信息模板在安装目录下，可自行修改。
* StudentInfo.cs
*
* 功 能： N/A
* 类 名： StudentInfo
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
	/// StudentInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class StudentInfo
	{
		public StudentInfo()
		{}
		#region Model
		private int _id;
		private string _sid;
		private string _spwd;
		private string _sname;
		private string _scolleges;
		private string _sroom;
		private string _slivedate;
		private string _sage;
		private string _ssex;
		private string _sadress;
		private string _sclass;
		private string _sphone;
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
		public string sid
		{
			set{ _sid=value;}
			get{return _sid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string spwd
		{
			set{ _spwd=value;}
			get{return _spwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sname
		{
			set{ _sname=value;}
			get{return _sname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string scolleges
		{
			set{ _scolleges=value;}
			get{return _scolleges;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sroom
		{
			set{ _sroom=value;}
			get{return _sroom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string slivedate
		{
			set{ _slivedate=value;}
			get{return _slivedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sage
		{
			set{ _sage=value;}
			get{return _sage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ssex
		{
			set{ _ssex=value;}
			get{return _ssex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sadress
		{
			set{ _sadress=value;}
			get{return _sadress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sclass
		{
			set{ _sclass=value;}
			get{return _sclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sphone
		{
			set{ _sphone=value;}
			get{return _sphone;}
		}
		#endregion Model

	}
}

