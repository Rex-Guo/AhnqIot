﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.8670
//     Support: http://www.cnblogs.com/huxj
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;


namespace AhnqIot.Hxj.DbModel
{

	/// <summary>
	/// 实体类DeviceControlLog 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class DeviceControlLog : Entity 
	{
		public DeviceControlLog():base("DeviceControlLog") {}

		#region Model
		private string _Serialnum;
		private DateTime _CreateTime;
		private string _CreateSysUserSerialnum;
		private DateTime _UpdateTime;
		private string _UpdateSysUserSerialnum;
		private string _DeviceSerialnum;
		private string _CommandSerialnum;
		private decimal _DeviceValue;
		private string _DeviceShowValue;
		private bool _ControlResult;
		private string _FailReason;
		private int _Sort;
		private string _Remark;
		/// <summary>
		/// 编码
		/// </summary>
		public string Serialnum
		{
			get{ return _Serialnum; }
			set
			{
				this.OnPropertyValueChange(_.Serialnum,_Serialnum,value);
				this._Serialnum=value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreateTime
		{
			get{ return _CreateTime; }
			set
			{
				this.OnPropertyValueChange(_.CreateTime,_CreateTime,value);
				this._CreateTime=value;
			}
		}
		/// <summary>
		/// 创建用户
		/// </summary>
		public string CreateSysUserSerialnum
		{
			get{ return _CreateSysUserSerialnum; }
			set
			{
				this.OnPropertyValueChange(_.CreateSysUserSerialnum,_CreateSysUserSerialnum,value);
				this._CreateSysUserSerialnum=value;
			}
		}
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime UpdateTime
		{
			get{ return _UpdateTime; }
			set
			{
				this.OnPropertyValueChange(_.UpdateTime,_UpdateTime,value);
				this._UpdateTime=value;
			}
		}
		/// <summary>
		/// 更新用户
		/// </summary>
		public string UpdateSysUserSerialnum
		{
			get{ return _UpdateSysUserSerialnum; }
			set
			{
				this.OnPropertyValueChange(_.UpdateSysUserSerialnum,_UpdateSysUserSerialnum,value);
				this._UpdateSysUserSerialnum=value;
			}
		}
		/// <summary>
		/// 设备编码
		/// </summary>
		public string DeviceSerialnum
		{
			get{ return _DeviceSerialnum; }
			set
			{
				this.OnPropertyValueChange(_.DeviceSerialnum,_DeviceSerialnum,value);
				this._DeviceSerialnum=value;
			}
		}
		/// <summary>
		/// 指令编码
		/// </summary>
		public string CommandSerialnum
		{
			get{ return _CommandSerialnum; }
			set
			{
				this.OnPropertyValueChange(_.CommandSerialnum,_CommandSerialnum,value);
				this._CommandSerialnum=value;
			}
		}
		/// <summary>
		/// 设备值
		/// </summary>
		public decimal DeviceValue
		{
			get{ return _DeviceValue; }
			set
			{
				this.OnPropertyValueChange(_.DeviceValue,_DeviceValue,value);
				this._DeviceValue=value;
			}
		}
		/// <summary>
		/// 设备显示值
		/// </summary>
		public string DeviceShowValue
		{
			get{ return _DeviceShowValue; }
			set
			{
				this.OnPropertyValueChange(_.DeviceShowValue,_DeviceShowValue,value);
				this._DeviceShowValue=value;
			}
		}
		/// <summary>
		/// 控制结果
		/// </summary>
		public bool ControlResult
		{
			get{ return _ControlResult; }
			set
			{
				this.OnPropertyValueChange(_.ControlResult,_ControlResult,value);
				this._ControlResult=value;
			}
		}
		/// <summary>
		/// 失败原因
		/// </summary>
		public string FailReason
		{
			get{ return _FailReason; }
			set
			{
				this.OnPropertyValueChange(_.FailReason,_FailReason,value);
				this._FailReason=value;
			}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int Sort
		{
			get{ return _Sort; }
			set
			{
				this.OnPropertyValueChange(_.Sort,_Sort,value);
				this._Sort=value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			get{ return _Remark; }
			set
			{
				this.OnPropertyValueChange(_.Remark,_Remark,value);
				this._Remark=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.Serialnum};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.Serialnum,
				_.CreateTime,
				_.CreateSysUserSerialnum,
				_.UpdateTime,
				_.UpdateSysUserSerialnum,
				_.DeviceSerialnum,
				_.CommandSerialnum,
				_.DeviceValue,
				_.DeviceShowValue,
				_.ControlResult,
				_.FailReason,
				_.Sort,
				_.Remark};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Serialnum,
				this._CreateTime,
				this._CreateSysUserSerialnum,
				this._UpdateTime,
				this._UpdateSysUserSerialnum,
				this._DeviceSerialnum,
				this._CommandSerialnum,
				this._DeviceValue,
				this._DeviceShowValue,
				this._ControlResult,
				this._FailReason,
				this._Sort,
				this._Remark};
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(IDataReader reader)
		{
			this._Serialnum = DataUtils.ConvertValue<string>(reader["Serialnum"]);
			this._CreateTime = DataUtils.ConvertValue<DateTime>(reader["CreateTime"]);
			this._CreateSysUserSerialnum = DataUtils.ConvertValue<string>(reader["CreateSysUserSerialnum"]);
			this._UpdateTime = DataUtils.ConvertValue<DateTime>(reader["UpdateTime"]);
			this._UpdateSysUserSerialnum = DataUtils.ConvertValue<string>(reader["UpdateSysUserSerialnum"]);
			this._DeviceSerialnum = DataUtils.ConvertValue<string>(reader["DeviceSerialnum"]);
			this._CommandSerialnum = DataUtils.ConvertValue<string>(reader["CommandSerialnum"]);
			this._DeviceValue = DataUtils.ConvertValue<decimal>(reader["DeviceValue"]);
			this._DeviceShowValue = DataUtils.ConvertValue<string>(reader["DeviceShowValue"]);
			this._ControlResult = DataUtils.ConvertValue<bool>(reader["ControlResult"]);
			this._FailReason = DataUtils.ConvertValue<string>(reader["FailReason"]);
			this._Sort = DataUtils.ConvertValue<int>(reader["Sort"]);
			this._Remark = DataUtils.ConvertValue<string>(reader["Remark"]);
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(DataRow row)
		{
			this._Serialnum = DataUtils.ConvertValue<string>(row["Serialnum"]);
			this._CreateTime = DataUtils.ConvertValue<DateTime>(row["CreateTime"]);
			this._CreateSysUserSerialnum = DataUtils.ConvertValue<string>(row["CreateSysUserSerialnum"]);
			this._UpdateTime = DataUtils.ConvertValue<DateTime>(row["UpdateTime"]);
			this._UpdateSysUserSerialnum = DataUtils.ConvertValue<string>(row["UpdateSysUserSerialnum"]);
			this._DeviceSerialnum = DataUtils.ConvertValue<string>(row["DeviceSerialnum"]);
			this._CommandSerialnum = DataUtils.ConvertValue<string>(row["CommandSerialnum"]);
			this._DeviceValue = DataUtils.ConvertValue<decimal>(row["DeviceValue"]);
			this._DeviceShowValue = DataUtils.ConvertValue<string>(row["DeviceShowValue"]);
			this._ControlResult = DataUtils.ConvertValue<bool>(row["ControlResult"]);
			this._FailReason = DataUtils.ConvertValue<string>(row["FailReason"]);
			this._Sort = DataUtils.ConvertValue<int>(row["Sort"]);
			this._Remark = DataUtils.ConvertValue<string>(row["Remark"]);
		}
		#endregion

		#region _Field
		/// <summary>
		/// 字段信息
		/// </summary>
		public class _
		{
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*","DeviceControlLog");
			/// <summary>
			/// 编码
			/// </summary>
			public readonly static Field Serialnum = new Field("Serialnum","DeviceControlLog","编码");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CreateTime = new Field("CreateTime","DeviceControlLog","创建时间");
			/// <summary>
			/// 创建用户
			/// </summary>
			public readonly static Field CreateSysUserSerialnum = new Field("CreateSysUserSerialnum","DeviceControlLog","创建用户");
			/// <summary>
			/// 更新时间
			/// </summary>
			public readonly static Field UpdateTime = new Field("UpdateTime","DeviceControlLog","更新时间");
			/// <summary>
			/// 更新用户
			/// </summary>
			public readonly static Field UpdateSysUserSerialnum = new Field("UpdateSysUserSerialnum","DeviceControlLog","更新用户");
			/// <summary>
			/// 设备编码
			/// </summary>
			public readonly static Field DeviceSerialnum = new Field("DeviceSerialnum","DeviceControlLog","设备编码");
			/// <summary>
			/// 指令编码
			/// </summary>
			public readonly static Field CommandSerialnum = new Field("CommandSerialnum","DeviceControlLog","指令编码");
			/// <summary>
			/// 设备值
			/// </summary>
			public readonly static Field DeviceValue = new Field("DeviceValue","DeviceControlLog","设备值");
			/// <summary>
			/// 设备显示值
			/// </summary>
			public readonly static Field DeviceShowValue = new Field("DeviceShowValue","DeviceControlLog","设备显示值");
			/// <summary>
			/// 控制结果
			/// </summary>
			public readonly static Field ControlResult = new Field("ControlResult","DeviceControlLog","控制结果");
			/// <summary>
			/// 失败原因
			/// </summary>
			public readonly static Field FailReason = new Field("FailReason","DeviceControlLog","失败原因");
			/// <summary>
			/// 排序
			/// </summary>
			public readonly static Field Sort = new Field("Sort","DeviceControlLog","排序");
			/// <summary>
			/// 备注
			/// </summary>
			public readonly static Field Remark = new Field("Remark","DeviceControlLog","备注");
		}
		#endregion


	}
}

