using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.IdentityFramework;
using Abp.UI;
using JetBrains.Annotations;
using LibraryProject.Authorization.Users;
using LibraryProject.Domain.Admin;
using LibraryProject.Domain.Member;
using LibraryProject.Services.AdminServices.Dtos;
using LibraryProject.Services.MemberServices.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.MemberServices
{
    public class MemberAppService : ApplicationService, IMemberAppService
    {
        private readonly IRepository<Member, Guid> _memberRepository;
        private readonly UserManager _userManager;
        
        public MemberAppService(IRepository <Member, Guid> memberRepository, UserManager userManager)
        {
            _memberRepository = memberRepository;
            _userManager = userManager;
        }

        [HttpPost]
        
        public async Task<MemberDto> CreateMemberAsync(MemberDto input)
        {
            var user = ObjectMapper.Map<User>(input);
            user.UserName = input.memberID;

            ObjectMapper.Map(input, user);
            if (!string.IsNullOrEmpty(user.NormalizedUserName) && !string.IsNullOrEmpty(user.NormalizedEmailAddress))
                user.SetNormalizedNames();
            user.TenantId = AbpSession.TenantId;
            await _userManager.InitializeOptionsAsync(AbpSession.TenantId);
            CheckErrors(await _userManager.CreateAsync(user, input.Password));

            var member = ObjectMapper.Map<Member>(input);
            member.User = user;
            await _memberRepository.InsertAsync(member);
            CurrentUnitOfWork.SaveChanges();

            return ObjectMapper.Map<MemberDto>(member);

        }
            public async Task DeleteMember(Guid id)
        {
                await _memberRepository.DeleteAsync(id);
            }

            [HttpGet]
            [Route("{id:Guid}")]

            public async Task<MemberDto> GetMemberAsync(Guid id)
            {
                //linq query to get the librarian by id
                var member = await _memberRepository.GetAllIncluding(e => e.User)
                    .FirstOrDefaultAsync(e => e.Id == id);
                if (member == null)
                {
                    throw new UserFriendlyException("member not found!");
                }


                return ObjectMapper.Map<MemberDto>(member);
            }
            [HttpPut]
            [Route("{id:Guid}")]
            public async Task<MemberDto> UpdateMemberAsync(MemberDto input)
            {
                var member = await _memberRepository.GetAsync(input.Id);
                var update = await _memberRepository.UpdateAsync(ObjectMapper.Map(input, member));

                return ObjectMapper.Map<MemberDto>(update);
            }
            protected virtual void CheckErrors(IdentityResult identityResult)
            {
                identityResult.CheckErrors(LocalizationManager);
            }

       


    }
}
