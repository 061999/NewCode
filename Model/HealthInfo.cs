/**  版本信息模板在安装目录下，可自行修改。
* HealthInfo.cs
*
* 功 能： N/A
* 类 名： HealthInfo
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
	/// HealthInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HealthInfo
	{
		public HealthInfo()
		{}
		#region Model
		private int _id;
		private string _bedroom;
		private string _controller;
		private string _healthscore="";
		private string _datetime;
		private string _questions="";
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
		public string bedroom
		{
			set{ _bedroom=value;}
			get{return _bedroom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string controller
		{
			set{ _controller=value;}
			get{return _controller;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string healthscore
		{
			set{ _healthscore=value;}
			get{return _healthscore;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string datetime
		{
			set{ _datetime=value;}
			get{return _datetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string questions
		{
			set{ _questions=value;}
			get{return _questions;}
		}
		#endregion Model

	}
}

