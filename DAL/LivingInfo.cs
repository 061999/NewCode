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
using System.Data;
using System.Text;
using System.Data.SqlClient;
//Please add references
namespace DAL
{
	/// <summary>
	/// 数据访问类:LivingInfo
	/// </summary>
	public partial class LivingInfo
	{
		public LivingInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "LivingInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from LivingInfo");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.LivingInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into LivingInfo(");
			strSql.Append("roomnumber,liveage,shouldlive,realitylive,livemoney,phone)");
			strSql.Append(" values (");
			strSql.Append("@roomnumber,@liveage,@shouldlive,@realitylive,@livemoney,@phone)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@roomnumber", SqlDbType.VarChar,50),
					new SqlParameter("@liveage", SqlDbType.VarChar,50),
					new SqlParameter("@shouldlive", SqlDbType.VarChar,50),
					new SqlParameter("@realitylive", SqlDbType.VarChar,50),
					new SqlParameter("@livemoney", SqlDbType.VarChar,50),
					new SqlParameter("@phone", SqlDbType.VarChar,50)};
			parameters[0].Value = model.roomnumber;
			parameters[1].Value = model.liveage;
			parameters[2].Value = model.shouldlive;
			parameters[3].Value = model.realitylive;
			parameters[4].Value = model.livemoney;
			parameters[5].Value = model.phone;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.LivingInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LivingInfo set ");
			strSql.Append("roomnumber=@roomnumber,");
			strSql.Append("liveage=@liveage,");
			strSql.Append("shouldlive=@shouldlive,");
			strSql.Append("realitylive=@realitylive,");
			strSql.Append("livemoney=@livemoney,");
			strSql.Append("phone=@phone");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@roomnumber", SqlDbType.VarChar,50),
					new SqlParameter("@liveage", SqlDbType.VarChar,50),
					new SqlParameter("@shouldlive", SqlDbType.VarChar,50),
					new SqlParameter("@realitylive", SqlDbType.VarChar,50),
					new SqlParameter("@livemoney", SqlDbType.VarChar,50),
					new SqlParameter("@phone", SqlDbType.VarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.roomnumber;
			parameters[1].Value = model.liveage;
			parameters[2].Value = model.shouldlive;
			parameters[3].Value = model.realitylive;
			parameters[4].Value = model.livemoney;
			parameters[5].Value = model.phone;
			parameters[6].Value = model.id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LivingInfo ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LivingInfo ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.LivingInfo GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,roomnumber,liveage,shouldlive,realitylive,livemoney,phone from LivingInfo ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Model.LivingInfo model=new Model.LivingInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.LivingInfo DataRowToModel(DataRow row)
		{
			Model.LivingInfo model=new Model.LivingInfo();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["roomnumber"]!=null)
				{
					model.roomnumber=row["roomnumber"].ToString();
				}
				if(row["liveage"]!=null)
				{
					model.liveage=row["liveage"].ToString();
				}
				if(row["shouldlive"]!=null)
				{
					model.shouldlive=row["shouldlive"].ToString();
				}
				if(row["realitylive"]!=null)
				{
					model.realitylive=row["realitylive"].ToString();
				}
				if(row["livemoney"]!=null)
				{
					model.livemoney=row["livemoney"].ToString();
				}
				if(row["phone"]!=null)
				{
					model.phone=row["phone"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,roomnumber,liveage,shouldlive,realitylive,livemoney,phone ");
			strSql.Append(" FROM LivingInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,roomnumber,liveage,shouldlive,realitylive,livemoney,phone ");
			strSql.Append(" FROM LivingInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM LivingInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from LivingInfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "LivingInfo";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

