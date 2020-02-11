using WebAPPFarmerCompanion.Models.Users;
using WebAPPFarmerCompanion.Models.FarmerModel;
using FarmerCompanionDBContext.FarmerSurvey;
using FarmerCompanionDBContext.Users;
using System.Collections.Generic;
using System;

namespace WebAPPFarmerCompanion.Models
{
    public static class ModelHelper
    {
        public static User ToLoginEntity(this LoginModel model)
        {
            User m = new User();
            m.UserName = model.LoginId;
            m.Password = model.Password;

            return m;
        }

        public static List<FarmerSurveyModel> ToFarmerSurveyModelList(this IEnumerable<FarmerSurveys> farmerSurveys)
        {
            List<FarmerSurveyModel> modelList = new List<FarmerSurveyModel>();
            try
            {
                foreach (var p in farmerSurveys)
                {
                    FarmerSurveyModel m = new FarmerSurveyModel { Survey_Id = p.Id, UserId = p.UserId, Answer_QA = p.AnswerQA, Answer_QB = p.AnswerQB, Answer_QC = p.AnswerQC, Recommendation = p.Recommendations, Survey_Date = p.SurveyDate };
                    modelList.Add(m);
                }
            }
            catch(Exception ex) { return null; }
            return modelList;
        }
    }
}