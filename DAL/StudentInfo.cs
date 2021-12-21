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
using System.Data;
using System.Text;
using System.Data.SqlClient;
//Please add references
namespace DAL
{
	/// <summary>
	/// 数据访问类:StudentInfo
	/// </summary>
	public partial class StudentInfo
	{
		public StudentInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "StudentInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from StudentInfo");
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
		public int Add(Model.StudentInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into StudentInfo(");
			strSql.Append("sid,spwd,sname,scolleges,sroom,slivedate,sage,ssex,sadress,sclass,sphone)");
			strSql.Append(" values (");
			strSql.Append("@sid,@spwd,@sname,@scolleges,@sroom,@slivedate,@sage,@ssex,@sadress,@sclass,@sphone)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@sid", SqlDbType.VarChar,50),
					new SqlParameter("@spwd", SqlDbType.VarChar,50),
					new SqlParameter("@sname", SqlDbType.VarChar,50),
					new SqlParameter("@scolleges", SqlDbType.VarChar,50),
					new SqlParameter("@sroom", SqlDbType.VarChar,50),
					new SqlParameter("@slivedate", SqlDbType.VarChar,50),
					new SqlParameter("@sage", SqlDbType.VarChar,50),
					new SqlParameter("@ssex", SqlDbType.VarChar,50),
					new SqlParameter("@sadress", SqlDbType.VarChar,50),
					new SqlParameter("@sclass", SqlDbType.VarChar,50),
					new SqlParameter("@sphone", SqlDbType.VarChar,50)};
			parameters[0].Value = model.sid;
			parameters[1].Value = model.spwd;
			parameters[2].Value = model.sname;
			parameters[3].Value = model.scolleges;
			parameters[4].Value = model.sroom;
			parameters[5].Value = model.slivedate;
			parameters[6].Value = model.sage;
			parameters[7].Value = model.ssex;
			parameters[8].Value = model.sadress;
			parameters[9].Value = model.sclass;
			parameters[10].Value = model.sphone;

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
		public bool Update(Model.StudentInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update StudentInfo set ");
			strSql.Append("sid=@sid,");
			strSql.Append("spwd=@spwd,");
			strSql.Append("sname=@sname,");
			strSql.Append("scolleges=@scolleges,");
			strSql.Append("sroom=@sroom,");
			strSql.Append("slivedate=@slivedate,");
			strSql.Append("sage=@sage,");
			strSql.Append("ssex=@ssex,");
			strSql.Append("sadress=@sadress,");
			strSql.Append("sclass=@sclass,");
			strSql.Append("sphone=@sphone");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@sid", SqlDbType.VarChar,50),
					new SqlParameter("@spwd", SqlDbType.VarChar,50),
					new SqlParameter("@sname", SqlDbType.VarChar,50),
					new SqlParameter("@scolleges", SqlDbType.VarChar,50),
					new SqlParameter("@sroom", SqlDbType.VarChar,50),
					new SqlParameter("@slivedate", SqlDbType.VarChar,50),
					new SqlParameter("@sage", SqlDbType.VarChar,50),
					new SqlParameter("@ssex", SqlDbType.VarChar,50),
					new SqlParameter("@sadress", SqlDbType.VarChar,50),
					new SqlParameter("@sclass", SqlDbType.VarChar,50),
					new SqlParameter("@sphone", SqlDbType.VarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.sid;
			parameters[1].Value = model.spwd;
			parameters[2].Value = model.sname;
			parameters[3].Value = model.scolleges;
			parameters[4].Value = model.sroom;
			parameters[5].Value = model.slivedate;
			parameters[6].Value = model.sage;
			parameters[7].Value = model.ssex;
			parameters[8].Value = model.sadress;
			parameters[9].Value = model.sclass;
			parameters[10].Value = model.sphone;
			parameters[11].Value = model.id;

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
			strSql.Append("delete from StudentInfo ");
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
			strSql.Append("delete from StudentInfo ");
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
		public Model.StudentInfo GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,sid,spwd,sname,scolleges,sroom,slivedate,sage,ssex,sadress,sclass,sphone from StudentInfo ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Model.StudentInfo model=new Model.StudentInfo();
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
		public Model.StudentInfo DataRowToModel(DataRow row)
		{
			Model.StudentInfo model=new Model.StudentInfo();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["sid"]!=null)
				{
					model.sid=row["sid"].ToString();
				}
				if(row["spwd"]!=null)
				{
					model.spwd=row["spwd"].ToString();
				}
				if(row["sname"]!=null)
				{
					model.sname=row["sname"].ToString();
				}
				if(row["scolleges"]!=null)
				{
					model.scolleges=row["scolleges"].ToString();
				}
				if(row["sroom"]!=null)
				{
					model.sroom=row["sroom"].ToString();
				}
				if(row["slivedate"]!=null)
				{
					model.slivedate=row["slivedate"].ToString();
				}
				if(row["sage"]!=null)
				{
					model.sage=row["sage"].ToString();
				}
				if(row["ssex"]!=null)
				{
					model.ssex=row["ssex"].ToString();
				}
				if(row["sadress"]!=null)
				{
					model.sadress=row["sadress"].ToString();
				}
				if(row["sclass"]!=null)
				{
					model.sclass=row["sclass"].ToString();
				}
				if(row["sphone"]!=null)
				{
					model.sphone=row["sphone"].ToString();
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
			strSql.Append("select id,sid,spwd,sname,scolleges,sroom,slivedate,sage,ssex,sadress,sclass,sphone ");
			strSql.Append(" FROM StudentInfo ");
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
			strSql.Append(" id,sid,spwd,sname,scolleges,sroom,slivedate,sage,ssex,sadress,sclass,sphone ");
			strSql.Append(" FROM StudentInfo ");
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
			strSql.Append("select count(1) FROM StudentInfo ");
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
			strSql.Append(")AS Row, T.*  from StudentInfo T ");
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
			parameters[0].Value = "StudentInfo";
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

