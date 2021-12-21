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
using System.Data;
using System.Text;
using System.Data.SqlClient;
//Please add references
namespace DAL
{
	/// <summary>
	/// 数据访问类:AdminInfo
	/// </summary>
	public partial class AdminInfo
	{
		public AdminInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "AdminInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from AdminInfo");
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
		public int Add(Model.AdminInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into AdminInfo(");
			strSql.Append("adminid,adminpwd,adminname,adminage,adminsex,adminroom,adminpost,adminadress)");
			strSql.Append(" values (");
			strSql.Append("@adminid,@adminpwd,@adminname,@adminage,@adminsex,@adminroom,@adminpost,@adminadress)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@adminid", SqlDbType.VarChar,50),
					new SqlParameter("@adminpwd", SqlDbType.VarChar,50),
					new SqlParameter("@adminname", SqlDbType.VarChar,50),
					new SqlParameter("@adminage", SqlDbType.VarChar,50),
					new SqlParameter("@adminsex", SqlDbType.VarChar,50),
					new SqlParameter("@adminroom", SqlDbType.VarChar,50),
					new SqlParameter("@adminpost", SqlDbType.VarChar,50),
					new SqlParameter("@adminadress", SqlDbType.VarChar,50)};
			parameters[0].Value = model.adminid;
			parameters[1].Value = model.adminpwd;
			parameters[2].Value = model.adminname;
			parameters[3].Value = model.adminage;
			parameters[4].Value = model.adminsex;
			parameters[5].Value = model.adminroom;
			parameters[6].Value = model.adminpost;
			parameters[7].Value = model.adminadress;

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
		public bool Update(Model.AdminInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update AdminInfo set ");
			strSql.Append("adminid=@adminid,");
			strSql.Append("adminpwd=@adminpwd,");
			strSql.Append("adminname=@adminname,");
			strSql.Append("adminage=@adminage,");
			strSql.Append("adminsex=@adminsex,");
			strSql.Append("adminroom=@adminroom,");
			strSql.Append("adminpost=@adminpost,");
			strSql.Append("adminadress=@adminadress");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@adminid", SqlDbType.VarChar,50),
					new SqlParameter("@adminpwd", SqlDbType.VarChar,50),
					new SqlParameter("@adminname", SqlDbType.VarChar,50),
					new SqlParameter("@adminage", SqlDbType.VarChar,50),
					new SqlParameter("@adminsex", SqlDbType.VarChar,50),
					new SqlParameter("@adminroom", SqlDbType.VarChar,50),
					new SqlParameter("@adminpost", SqlDbType.VarChar,50),
					new SqlParameter("@adminadress", SqlDbType.VarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.adminid;
			parameters[1].Value = model.adminpwd;
			parameters[2].Value = model.adminname;
			parameters[3].Value = model.adminage;
			parameters[4].Value = model.adminsex;
			parameters[5].Value = model.adminroom;
			parameters[6].Value = model.adminpost;
			parameters[7].Value = model.adminadress;
			parameters[8].Value = model.id;

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
			strSql.Append("delete from AdminInfo ");
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
			strSql.Append("delete from AdminInfo ");
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
		public Model.AdminInfo GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,adminid,adminpwd,adminname,adminage,adminsex,adminroom,adminpost,adminadress from AdminInfo ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Model.AdminInfo model=new Model.AdminInfo();
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
		public Model.AdminInfo DataRowToModel(DataRow row)
		{
			Model.AdminInfo model=new Model.AdminInfo();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["adminid"]!=null)
				{
					model.adminid=row["adminid"].ToString();
				}
				if(row["adminpwd"]!=null)
				{
					model.adminpwd=row["adminpwd"].ToString();
				}
				if(row["adminname"]!=null)
				{
					model.adminname=row["adminname"].ToString();
				}
				if(row["adminage"]!=null)
				{
					model.adminage=row["adminage"].ToString();
				}
				if(row["adminsex"]!=null)
				{
					model.adminsex=row["adminsex"].ToString();
				}
				if(row["adminroom"]!=null)
				{
					model.adminroom=row["adminroom"].ToString();
				}
				if(row["adminpost"]!=null)
				{
					model.adminpost=row["adminpost"].ToString();
				}
				if(row["adminadress"]!=null)
				{
					model.adminadress=row["adminadress"].ToString();
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
			strSql.Append("select id,adminid,adminpwd,adminname,adminage,adminsex,adminroom,adminpost,adminadress ");
			strSql.Append(" FROM AdminInfo ");
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
			strSql.Append(" id,adminid,adminpwd,adminname,adminage,adminsex,adminroom,adminpost,adminadress ");
			strSql.Append(" FROM AdminInfo ");
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
			strSql.Append("select count(1) FROM AdminInfo ");
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
			strSql.Append(")AS Row, T.*  from AdminInfo T ");
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
			parameters[0].Value = "AdminInfo";
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

