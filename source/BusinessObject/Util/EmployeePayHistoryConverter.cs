//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
// DTO 模型与数据层的实体 相互 转换工具 类
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessObject.Util
{
    using System;using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;using Newtonsoft.Json;
     using DataTransferObject.Model;using BusinessEntities;
     using DataTransferObject;
    using System.Collections.Generic;
    
    public interface IEmployeePayHistoryConverter
        {
            EmployeePayHistory ConvertDtoToEntities(EmployeePayHistoryDto _EmployeePayHistoryDto);
            EmployeePayHistory ConvertDtoToEntities(EmployeePayHistoryDto _EmployeePayHistoryDto, EmployeePayHistory efEmployeePayHistory);
            EmployeePayHistory ConvertDtoToEntities(EmployeePayHistoryDto _EmployeePayHistoryDto,bool skipNullPropertyValue);
            EmployeePayHistory ConvertDtoToEntities(EmployeePayHistoryDto _EmployeePayHistoryDto, EmployeePayHistory efEmployeePayHistory, bool skipNullPropertyValue);
            EmployeePayHistoryDto ConvertEntitiesToDto(EmployeePayHistory _EmployeePayHistory);
         }
    public partial class EmployeePayHistoryConverter: IEmployeePayHistoryConverter
    {
           /// <summary>
           /// Converts the dto to entities.
           /// </summary>
           /// <param name="_EmployeePayHistoryDto">The EmployeePayHistory dto.</param>
           /// <returns>EmployeePayHistory</returns>
           public EmployeePayHistory ConvertDtoToEntities(EmployeePayHistoryDto _EmployeePayHistoryDto)
           {
              if (_EmployeePayHistoryDto==null)
              {
                  throw new ArgumentNullException("model should not be null");
              }
              var efEmployeePayHistory=new EmployeePayHistory();
              ConvertObject(_EmployeePayHistoryDto, efEmployeePayHistory);
              return efEmployeePayHistory;
           }
    
              /// <summary>
              /// Converts the dto to entities.
              /// </summary>
              /// <param name="_EmployeePayHistoryDto">The EmployeePayHistory dto</param>
              /// <param name="efEmployeePayHistory">已存在的EmployeePayHistory EF model</param>
              /// <returns>EmployeePayHistory</returns>
             public EmployeePayHistory ConvertDtoToEntities(EmployeePayHistoryDto _EmployeePayHistoryDto, EmployeePayHistory efEmployeePayHistory)
             {
                  if (_EmployeePayHistoryDto==null && efEmployeePayHistory==null)
                  {
                       throw new ArgumentNullException("models should not be null");
                  }
                   ConvertObject(_EmployeePayHistoryDto, efEmployeePayHistory);
                   return efEmployeePayHistory;
             }
    
           /// <summary>
           /// Converts the dto to entities.
           /// </summary>
           /// <param name="_EmployeePayHistoryDto">The EmployeePayHistory dto.</param>
           /// <param name="skipNullPropertyValue">if set to <c>true</c> [skip null property value].</param>
          /// <returns>EmployeePayHistory</returns>
         public EmployeePayHistory ConvertDtoToEntities(EmployeePayHistoryDto _EmployeePayHistoryDto,bool skipNullPropertyValue)
        {
              if (_EmployeePayHistoryDto==null)
              {
                  throw new ArgumentNullException("model should not be null");
              }
    
             var efEmployeePayHistory=new EmployeePayHistory();
    
             ConvertObjectWithCheckNull(_EmployeePayHistoryDto, skipNullPropertyValue, efEmployeePayHistory);
             return efEmployeePayHistory;
         }
    
             /// <summary>
             /// Converts the dto to entities.
             /// </summary>
             /// <param name="_ EmployeePayHistoryDto">The  EmployeePayHistory dto.</param>
             /// <param name="ef EmployeePayHistory">已存的EntityFramework实体 ef EmployeePayHistory</param>
             /// <param name="skipNullPropertyValue">if set to <c>true</c> [skip null property value].</param>
             /// <returns>EmployeePayHistory</returns>
           public EmployeePayHistory ConvertDtoToEntities(EmployeePayHistoryDto _EmployeePayHistoryDto, EmployeePayHistory efEmployeePayHistory, bool skipNullPropertyValue)
           {
                  if (_EmployeePayHistoryDto==null && efEmployeePayHistory==null)
                  {
                       throw new ArgumentNullException("models should not be null");
                  }
    
                 ConvertObjectWithCheckNull(_EmployeePayHistoryDto, skipNullPropertyValue, efEmployeePayHistory);
                 return efEmployeePayHistory;
           }
    
          private static void ConvertObjectWithCheckNull(EmployeePayHistoryDto _EmployeePayHistoryDto, bool skipNullPropertyValue, EmployeePayHistory efEmployeePayHistory)
          {
               efEmployeePayHistory.EmployeeID=_EmployeePayHistoryDto.EmployeeID;
                    efEmployeePayHistory.RateChangeDate=_EmployeePayHistoryDto.RateChangeDate;
                    efEmployeePayHistory.Rate=_EmployeePayHistoryDto.Rate;
                    efEmployeePayHistory.PayFrequency=_EmployeePayHistoryDto.PayFrequency;
                    efEmployeePayHistory.ModifiedDate=_EmployeePayHistoryDto.ModifiedDate;
         
            }
    
           /// <summary>
           /// Converts the entities to dto.
          /// </summary>
          /// <param name="_EmployeePayHistory">The EmployeePayHistory entity</param>
          /// <returns>EmployeePayHistoryDto</returns>
         public EmployeePayHistoryDto ConvertEntitiesToDto(EmployeePayHistory  _EmployeePayHistory)
        {
              if (_EmployeePayHistory==null)
              {
                       throw new ArgumentNullException("models should not be null");
              }
    
             var _EmployeePayHistoryDto =new EmployeePayHistoryDto();
                         _EmployeePayHistoryDto.EmployeeID=_EmployeePayHistory.EmployeeID; 
                  _EmployeePayHistoryDto.RateChangeDate=_EmployeePayHistory.RateChangeDate; 
                  _EmployeePayHistoryDto.Rate=_EmployeePayHistory.Rate; 
                  _EmployeePayHistoryDto.PayFrequency=_EmployeePayHistory.PayFrequency; 
                  _EmployeePayHistoryDto.ModifiedDate=_EmployeePayHistory.ModifiedDate; 
                 return _EmployeePayHistoryDto;
        }
    
           private static void ConvertObject(EmployeePayHistoryDto _EmployeePayHistoryDto, EmployeePayHistory efEmployeePayHistory)
           {
               efEmployeePayHistory.EmployeeID=_EmployeePayHistoryDto.EmployeeID; 
                  efEmployeePayHistory.RateChangeDate=_EmployeePayHistoryDto.RateChangeDate; 
                  efEmployeePayHistory.Rate=_EmployeePayHistoryDto.Rate; 
                  efEmployeePayHistory.PayFrequency=_EmployeePayHistoryDto.PayFrequency; 
                  efEmployeePayHistory.ModifiedDate=_EmployeePayHistoryDto.ModifiedDate; 
              }
    
        //public virtual EmployeeDto Employees { get; set; }
    }
           public class FakeEmployeePayHistoryConverter:IEmployeePayHistoryConverter
           {
    
            public EmployeePayHistory ConvertDtoToEntities(EmployeePayHistoryDto _EmployeePayHistoryDto)
            {
                return new EmployeePayHistory();
            }
    
            public EmployeePayHistory ConvertDtoToEntities(EmployeePayHistoryDto _EmployeePayHistoryDto, EmployeePayHistory efEmployeePayHistory)
            {
                return new EmployeePayHistory();
            }
    
            public EmployeePayHistory ConvertDtoToEntities(EmployeePayHistoryDto _EmployeePayHistoryDto, bool skipNullPropertyValue)
            {
                return new EmployeePayHistory();
            }
    
            public EmployeePayHistory ConvertDtoToEntities(EmployeePayHistoryDto _EmployeePayHistoryDto, EmployeePayHistory efEmployeePayHistory, bool skipNullPropertyValue)
            {
                return new EmployeePayHistory();
            }
    
            public EmployeePayHistoryDto ConvertEntitiesToDto(EmployeePayHistory _EmployeePayHistory)
            {
                return new EmployeePayHistoryDto();
            }
          }
}
