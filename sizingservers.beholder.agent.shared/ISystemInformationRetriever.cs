﻿/*
 * 2017 Sizing Servers Lab
 * University College of West-Flanders, Department GKG
 * 
 */

namespace sizingservers.beholder.agent.shared {
    public interface ISystemInformationRetriever {
        SystemInformation Retrieve();
    }
}
