﻿namespace MyTested.AspNetCore.Mvc.Builders.And
{
    using Actions;
    using Base;
    using Contracts.Actions;
    using Contracts.And;
    using Internal;
    using Internal.TestContexts;

    /// <summary>
    /// Class containing AndAlso() method allowing additional assertions after action tests.
    /// </summary>
    /// <typeparam name="TActionResult">Result from invoked action in ASP.NET Core MVC controller.</typeparam>
    public class AndActionResultTestBuilder<TActionResult> : BaseTestBuilderWithActionResult<TActionResult>,
        IAndActionResultTestBuilder<TActionResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AndActionResultTestBuilder{TActionResult}"/> class.
        /// </summary>
        /// <param name="testContext"><see cref="ControllerTestContext"/> containing data about the currently executed assertion chain.</param>
        public AndActionResultTestBuilder(ControllerTestContext testContext)
            : base(testContext)
        {
            TestHelper.ExecuteTestCleanup();
        }

        /// <inheritdoc />
        public IActionResultTestBuilder<TActionResult> AndAlso()
        {
            return new ActionResultTestBuilder<TActionResult>(this.TestContext);
        }
    }
}
