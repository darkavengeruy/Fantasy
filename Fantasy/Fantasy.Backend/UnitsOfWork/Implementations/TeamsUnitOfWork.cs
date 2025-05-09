﻿using Fantasy.Backend.Repositories.Interfaces;
using Fantasy.Backend.UnitOfWork.Interfaces;
using Fantasy.Shared.DTOs;
using Fantasy.Shared.Entities;
using Fantasy.Shared.Responses;

namespace Fantasy.Backend.UnitOfWork.Implementations;

public class TeamsUnitOfWork : GenericUnitOfWork<Team>, ITeamsUnitOfWork
{
    private readonly ITeamsRepository _teamsRepository;

    public TeamsUnitOfWork(IGenericRepository<Team> repository, ITeamsRepository teamsRepository) : base(repository)
    {
        _teamsRepository = teamsRepository;
    }

    public override async Task<ActionResponse<IEnumerable<Team>>> GetAsync() => await _teamsRepository.GetAsync();

    public override async Task<ActionResponse<Team>> GetAsync(int id) => await _teamsRepository.GetAsync(id);

    public override async Task<ActionResponse<IEnumerable<Team>>> GetAsync(PaginationDTO pagination) => await _teamsRepository.GetAsync(pagination);

    public async Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination) => await _teamsRepository.GetTotalRecordsAsync(pagination);

    public async Task<ActionResponse<Team>> AddAsync(TeamDTO teamDTO) => await _teamsRepository.AddAsync(teamDTO);

    public async Task<IEnumerable<Team>> GetComboAsync(int countryId) => await _teamsRepository.GetComboAsync(countryId);

    public async Task<ActionResponse<Team>> UpdateAsync(TeamDTO teamDTO) => await _teamsRepository.UpdateAsync(teamDTO);
}