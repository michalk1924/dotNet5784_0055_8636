﻿namespace BlApi;

public interface IMilestone
{
    public BO.Milestone Read(int id);
    public void Update(BO.Milestone milestone);
}
