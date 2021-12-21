/**  版本信息模板在安装目录下，可自行修改。
* GoodsInfo.cs
*
* 功 能： N/A
* 类 名： GoodsInfo
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
	/// GoodsInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class GoodsInfo
	{
		public GoodsInfo()
		{}
		#region Model
		private int _id;
		private string _goods;
		private string _porter;
		private string _outtime;
		private string _returntime;
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
		public string goods
		{
			set{ _goods=value;}
			get{return _goods;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string porter
		{
			set{ _porter=value;}
			get{return _porter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string outtime
		{
			set{ _outtime=value;}
			get{return _outtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string returntime
		{
			set{ _returntime=value;}
			get{return _returntime;}
		}
		#endregion Model

	}
}

