﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FGAE
{
    public class AI_Controller : BaseSpaceShipController
    {
        public float distance= float.MaxValue;

        public SpaceShip spaceShip_FGAE;
        public GameData data_FGAE;
        public float thrust;
        public float targetOrient;

        private void Start()
        {
            if(GetComponent<Animator>() == null)
            {
                Animator animator = gameObject.AddComponent<Animator>();
                animator.runtimeAnimatorController = Resources.Load("FGAE_StateMachineController_Easy") as RuntimeAnimatorController;
            }
        }

        public override InputData UpdateInput(SpaceShip spaceship, GameData data)
        {
            if(spaceShip_FGAE == null)
                spaceShip_FGAE = spaceship;
            data_FGAE = data;

            return new InputData(thrust, targetOrient, false, false);
        }
    }
}