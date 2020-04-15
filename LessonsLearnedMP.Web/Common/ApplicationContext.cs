using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Http;
using Suncor.LessonsLearnedMP.Data;
using Suncor.LessonsLearnedMP.Framework;

namespace Suncor.LessonsLearnedMP.Web.Common
{
    public class ApplicationContext : IApplicationContext
    {
        private readonly HttpContext _context;

        public void Clear()
        {
            this.AllUsers = null;
            this.AllReferenceValues = null;
        }

        public ApplicationContext(HttpContext context)
        {
            _context = context;
        }

        public List<ReferenceValue> AllReferenceValues
        {
            get
            {
                /*
                if (_context != null && _context.Application != null)
                {
                    return (List<ReferenceValue>)_context.Application["AllReferenceValues"];
                }
                */
                return new List<ReferenceValue>();
            }
            set
            {
                /*
                if (_context != null && _context.Application != null)
                {
                    _context.Application["AllReferenceValues"] = value;
                }*/
            }
        }

        public List<ReferenceValue> LessonStatuses
        {
            get
            {
                return this.AllReferenceValues.Where(x => x.ReferenceTypeId == (int)Enumerations.ReferenceType.LessonStatus || x.ReferenceTypeId == (int)Enumerations.ReferenceType.System).OrderBy(x => x.SortOrder).ToList();
            }
        }

        public List<ReferenceValue> Projects
        {
            get
            {
                return this.AllReferenceValues.Where(x => x.ReferenceTypeId == (int)Enumerations.ReferenceType.Project || x.ReferenceTypeId == (int)Enumerations.ReferenceType.System).OrderBy(x => x.SortOrder).ToList();
            }
        }

        public List<ReferenceValue> Phases
        {
            get
            {
                return this.AllReferenceValues.Where(x => x.ReferenceTypeId == (int)Enumerations.ReferenceType.Phase || x.ReferenceTypeId == (int)Enumerations.ReferenceType.System).OrderBy(x => x.SortOrder).ToList();
            }
        }

        public List<ReferenceValue> Classifications
        {
            get
            {
                return this.AllReferenceValues.Where(x => x.ReferenceTypeId == (int)Enumerations.ReferenceType.Classification || x.ReferenceTypeId == (int)Enumerations.ReferenceType.System).OrderBy(x => x.SortOrder).ToList();
            }
        }

        public List<ReferenceValue> Locations
        {
            get
            {
                return this.AllReferenceValues.Where(x => x.ReferenceTypeId == (int)Enumerations.ReferenceType.Location || x.ReferenceTypeId == (int)Enumerations.ReferenceType.System).OrderBy(x => x.SortOrder).ToList();
            }
        }

        public List<ReferenceValue> ImpactBenefitRanges
        {
            get
            {
                return this.AllReferenceValues.Where(x => x.ReferenceTypeId == (int)Enumerations.ReferenceType.ImpactBenefitRange || x.ReferenceTypeId == (int)Enumerations.ReferenceType.System).OrderBy(x => x.SortOrder).ToList();
            }
        }

        public List<ReferenceValue> CostImpacts
        {
            get
            {
                return this.AllReferenceValues.Where(x => x.ReferenceTypeId == (int)Enumerations.ReferenceType.CostImpact || x.ReferenceTypeId == (int)Enumerations.ReferenceType.System).OrderBy(x => x.SortOrder).ToList();
            }
        }

        public List<ReferenceValue> RiskRankings
        {
            get
            {
                return this.AllReferenceValues.Where(x => x.ReferenceTypeId == (int)Enumerations.ReferenceType.RiskRanking || x.ReferenceTypeId == (int)Enumerations.ReferenceType.System).OrderBy(x => x.SortOrder).ToList();
            }
        }

        public List<ReferenceValue> Disciplines
        {
            get
            {
                return this.AllReferenceValues.Where(x => x.ReferenceTypeId == (int)Enumerations.ReferenceType.Discipline || x.ReferenceTypeId == (int)Enumerations.ReferenceType.System).OrderBy(x => x.SortOrder).ToList();
            }
        }

        public List<ReferenceValue> CredibilityChecklists
        {
            get
            {
                return this.AllReferenceValues.Where(x => x.ReferenceTypeId == (int)Enumerations.ReferenceType.CredibilityChecklist || x.ReferenceTypeId == (int)Enumerations.ReferenceType.System).OrderBy(x => x.SortOrder).ToList();
            }
        }

        public List<ReferenceValue> LessonTypesValid
        {
            get
            {
                return this.AllReferenceValues.Where(x => x.ReferenceTypeId == (int)Enumerations.ReferenceType.LessonTypeValid || x.ReferenceTypeId == (int)Enumerations.ReferenceType.System).OrderBy(x => x.SortOrder).ToList();
            }
        }

        public List<ReferenceValue> LessonTypesInvalid
        {
            get
            {
                return this.AllReferenceValues.Where(x => x.ReferenceTypeId == (int)Enumerations.ReferenceType.LessonTypeInvalid || x.ReferenceTypeId == (int)Enumerations.ReferenceType.System).OrderBy(x => x.SortOrder).ToList();
            }
        }

        public List<ReferenceValue> CommentTypes
        {
            get
            {
                return this.AllReferenceValues.Where(x => x.ReferenceTypeId == (int)Enumerations.ReferenceType.CommentType || x.ReferenceTypeId == (int)Enumerations.ReferenceType.System).OrderBy(x => x.SortOrder).ToList();
            }
        }

        public List<ReferenceValue> SystemValues
        {
            get
            {
                return this.AllReferenceValues.Where(x => x.ReferenceTypeId == (int)Enumerations.ReferenceType.System).OrderBy(x => x.SortOrder).ToList();
            }
        }

        public List<ReferenceValue> Themes
        {
            get
            {
                return this.AllReferenceValues.Where(x => x.ReferenceTypeId == (int)Enumerations.ReferenceType.Theme || x.ReferenceTypeId == (int)Enumerations.ReferenceType.System).OrderBy(x => x.SortOrder).ToList();
            }
        }

        public List<ReferenceType> ReferenceTypes
        {
            get
            {
                /*
                if (_context != null && _context.Application != null)
                {
                    return (List<ReferenceType>)_context.Application["ReferenceTypes"];
                }
                */
                return new List<ReferenceType>();
            }
            set
            {
                /*
                if (_context != null && _context.Application != null)
                {
                    _context.Application["ReferenceTypes"] = value;
                }*/
            }
        }

        public List<RoleUser> Coordinators
        {
            get
            {
                return this.AllUsers.Where(x => x.RoleId == (int)Enumerations.Role.Coordinator).OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
            }
        }

        public List<RoleUser> Bpos
        {
            get
            {
                return this.AllUsers.Where(x => x.RoleId == (int)Enumerations.Role.BPO).OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
            }
        }

        public List<RoleUser> Admins
        {
            get
            {
                return this.AllUsers.Where(x => x.RoleId == (int)Enumerations.Role.Administrator).OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
            }
        }

        public List<RoleUser> DisciplineUsers
        {
            get
            {
                return this.AllUsers.Where(x => x.DisciplineId != null).OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
            }
        }

        public List<RoleUser> AllUsers
        {
            get
            {
                /*
                if (_context != null && _context.Application != null)
                {
                    return (List<RoleUser>)_context.Application["AllUsers"];
                }*/

                return new List<RoleUser>();
            }
            set
            {
                /*
                if (_context != null && _context.Application != null)
                {
                    _context.Application["AllUsers"] = value;
                }*/
            }
        }

        public DateTime LastRefresh
        {
            get
            {
                /*
                if (_context != null && _context.Application != null)
                {
                    var result = _context.Application["LastRefresh"];
                    return result == null ? DateTime.MinValue : (DateTime)result;
                }*/

                return DateTime.MinValue;
            }
            set
            {
                /*
                if (_context != null && _context.Application != null)
                {
                    _context.Application["LastRefresh"] = value;
                }*/
            }
        }
    }
}
