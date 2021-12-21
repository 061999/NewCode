/**  版本信息模板在安装目录下，可自行修改。
* BuildingInfo.cs
*
* 功 能： N/A
* 类 名： BuildingInfo
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
	/// BuildingInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BuildingInfo
	{
		public BuildingInfo()
		{}
		#region Model
		private int _id;
		private string _buildnumber;
		private string _rooms;
		private string _builds;
		private string _shouldlive;
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
		public string buildnumber
		{
			set{ _buildnumber=value;}
			get{return _buildnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rooms
		{
			set{ _rooms=value;}
			get{return _rooms;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string builds
		{
			set{ _builds=value;}
			get{return _builds;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string shouldlive
		{
			set{ _shouldlive=value;}
			get{return _shouldlive;}
		}
		#endregion Model

	}
}

