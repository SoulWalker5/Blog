using AutoMapper;
using BL.BLModel;
using DAL.Entity;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Service
{
    public interface IArticleService : IGenericService<ArticleBL>
    {

    }
    public class ArticleService : GenericService<ArticleBL, Article>, IArticleService
    {
        private readonly IMapper _mapper;
        public ArticleService(IGenericRepository<Article> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        public override ArticleBL Map(Article model)
        {
            return _mapper.Map<ArticleBL>(model);
        }
        public override Article Map(ArticleBL model)
        {
            throw new System.NotImplementedException();
        }
        public override IEnumerable<ArticleBL> Map(IList<Article> entitiesList)
        {
            return _mapper.Map<IEnumerable<ArticleBL>>(entitiesList);
        }
        public override IEnumerable<Article> Map(IList<ArticleBL> entitiesList)
        {
            return _mapper.Map<IEnumerable<Article>>(entitiesList);
        }
    }
}
