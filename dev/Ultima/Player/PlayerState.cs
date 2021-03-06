﻿using UltimaXNA.Ultima.Data;
using UltimaXNA.Ultima.Player.Partying;

namespace UltimaXNA.Ultima.Player {
    class PlayerState {
        static readonly PlayerState m_Instance;

        JournalData m_Journal;
        SkillData m_Skills;
        StatLockData m_StatLocks;
        PartySystem m_Partying;
        Features m_Features;

        static PlayerState() {
            m_Instance = new PlayerState();
            m_Instance.m_Journal = new JournalData();
            m_Instance.m_Skills = new SkillData();
            m_Instance.m_StatLocks = new StatLockData();
            m_Instance.m_Partying = new PartySystem();
            m_Instance.m_Features = new Features();
        }

        public static JournalData Journaling => m_Instance.m_Journal;
        public static SkillData Skills => m_Instance.m_Skills;
        public static StatLockData StatLocks => m_Instance.m_StatLocks;
        public static PartySystem Partying => m_Instance.m_Partying;
        public static Features ClientFeatures => m_Instance.m_Features;
        public static AssistantFeatures DisabledFeatures = AssistantFeatures.None;
    }
}
