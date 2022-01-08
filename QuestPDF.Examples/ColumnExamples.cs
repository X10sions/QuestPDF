﻿using NUnit.Framework;
using QuestPDF.Examples.Engine;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace QuestPDF.Examples
{
    public class ColumnExamples
    {
        [Test]
        public void Column()
        {
            RenderingTest
                .Create()
                .PageSize(PageSizes.A4)
                .ShowResults()
                .ProducePdf()
                .Render(container =>
                {
                    container.Column(column =>
                    {
                        column.Item().Element(Block);

                        static void Block(IContainer container)
                        {
                            container
                                .Width(100)
                                .Height(100)
                                .Background(Placeholders.BackgroundColor());
                        }
                    });
                });
        }
    }
}